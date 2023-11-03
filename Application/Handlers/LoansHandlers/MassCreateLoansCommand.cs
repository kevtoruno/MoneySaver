using MediatR;
using Service.Core.Dtos.LoansDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Service.Core.Interfaces;
using Domain.Entities.Loans;
using Service.Features.Loans;
using Service.Core.Dtos;
using Domain.Entities;
using Domain;

namespace Service.Handlers.LoansHandlers;

public class MassCreateLoansCommand : IRequest<Result<bool>>
{
    public string Path { get; set; }
}

internal class MassCreateLoansHandler : IRequestHandler<MassCreateLoansCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;
    private List<LoansForPreviewMassCreationDto> loansForPreviewDto;
    private List<LoanDomainCreator> LoansToBeCreated = new List<LoanDomainCreator>();
    public MassCreateLoansHandler(IMoneySaverRepository moneySaverRepo, 
        ILoansRepository loansRepo, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<Result<bool>> Handle(MassCreateLoansCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var loanMassCreator = new LoansMassCreator(_moneySaverRepo, _loansRepo);

            loansForPreviewDto = loanMassCreator.GenerateLoanMassCreationPreview(request.Path).Value;
            
            var defaultCompany = _moneySaverRepo.GetDefaultCompany();

            if (loansForPreviewDto.Where(lp => lp.IsValid).Any() == false)
                return Task.FromResult(Result<bool>.Failure("Ningún registro es válido"));

            decimal totalAmountToBeLoaned = loansForPreviewDto.Where(lp => lp.IsValid).Sum(a => a.LoanAmount);

            if (totalAmountToBeLoaned > defaultCompany.CurrentAmount)
                return Task.FromResult(Result<bool>.Failure("No existen fondos suficientes para realizar el préstamo."));

            CreateLoanDomains(defaultCompany);

            _loansRepo.SaveLoan(LoansToBeCreated);

            return Task.FromResult(Result<bool>.Created(true, "Se han creado todos los préstamos"));
        }
        catch (Exception ex)
        {
            return Task.FromResult(Result<bool>.Failure(ex.Message));
        } 
    }

    private void CreateLoanDomains(CompanyDomain defaultCompany)
    {
        var defaultLoanInterest = _loansRepo.GetDefaultLoanInterest();
        var defaultLoanInterestDomain = _mapper.Map<LoanInterestsDomain>(defaultLoanInterest);

        var subPeriods = GetSubPeriodsForLoans();

        if (loansForPreviewDto.Max(a => a.TotalInstallments) > subPeriods.Count)
            throw new Exception("No existe subperiodos suficientes para cubrir todas las cuotas requeridas.");

        foreach (var loanPreview in loansForPreviewDto.Where(lp => lp.IsValid))
        {
            var endDateForLoan = CalculateEndDateForLoan(loanPreview.Date, loanPreview.TotalInstallments);

            var loanDomain = new LoanDomainCreator(loanPreview.ClientID, description: "", loanPreview.TotalInstallments,
            loanPreview.LoanAmount, defaultLoanInterestDomain, loanPreview.Date,
            endDateForLoan, guarantorFullName: "", guarantorWorkArea: "",
            guarantorINSSNo: "", guarantorBaseIncome: 0, guarantorAddress: "", loanPreview.CKCode, defaultCompany);

            loanDomain.CreateLoan(subPeriods);

            LoansToBeCreated.Add(loanDomain);
        }
    }

    private DateTime CalculateEndDateForLoan(DateTime startDate, int loanTerms)
    {
        DateTime endDate = startDate.AddMonths(loanTerms-1).Date;

        int daysInEndDateMonth = DateTime.DaysInMonth(endDate.Year, endDate.Month);

        if (startDate.Day > daysInEndDateMonth)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, daysInEndDateMonth);
        }

        return endDate;
    }

    private List<SubPeriodDomain> GetSubPeriodsForLoans() 
    {
        var anyValidLoan = loansForPreviewDto.FirstOrDefault(lp => lp.IsValid);

        var subPeriodsForLoan = new List<SubPeriodDomain>();

        if (anyValidLoan != null) 
        {
            DateTime startDate = anyValidLoan.Date;
            DateTime endDate = anyValidLoan.Date.AddMonths(9); //10 is the max of installments that there can be

            subPeriodsForLoan = _moneySaverRepo.GetSubPeriodsForDateRange(startDate, endDate);
        }

        return subPeriodsForLoan;
    }
}
