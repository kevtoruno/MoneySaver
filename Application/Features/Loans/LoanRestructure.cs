using AutoMapper;
using Domain.DomainExceptions;
using Domain.Entities.Loans;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.DataModel.Loan;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    
    internal class LoanRestructure
    {
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;
        private List<LoanTransactionsDto> LoansTransactionDto;
        private LoanRestructureHistoryDataModel LoanRestructureHistory;
        public LoanRestructure(ILoansRepository loansRepo, IMapper mapper)
        {
            _loansRepo = loansRepo;
            _mapper = mapper;
            LoansTransactionDto = new List<LoanTransactionsDto>();
            LoanRestructureHistory = new LoanRestructureHistoryDataModel();
        }

        public Result<bool> SaveLoanRestructure(int loanID)
        {
            try
            {
                var loansData = _loansRepo.GetLoansData(loanID);

                var loanDomain = _mapper.Map<LoanDomain>(loansData);

                SetPreviousDataRestructureHistory(loansData);
                loanDomain.RestructureLoan();

                LoanRestructureHistory.NewTermAmount = loanDomain.LoanInstallments.Last().DueAmount;
                LoanRestructureHistory.NewTotalTerms = loanDomain.LoanInstallments.Count;

                _mapper.Map(loanDomain, loansData);

                _loansRepo.UpdateLoanRestructure(loansData, LoanRestructureHistory);

                return Result<bool>.Created(true, "El préstamo ha sido reestructurado exitosamente");
            }
            catch (BaseDomainException ex)
            {
                Helper.SendErrorToText(ex);
                return Result<bool>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<bool>.Failure("Hubo un error no manejado.");
            }
        }

        private void SetPreviousDataRestructureHistory(LoansDataModel loansData)
        {
            decimal previousTermAmount = loansData.TermAmount;
            int previousTotalTerms = loansData.TotalTerms;

            if (loansData.Restructures.Count > 0)
            {
                previousTermAmount = loansData.Restructures.OrderByDescending(r => r.Date).First().NewTermAmount;
                previousTotalTerms = loansData.Restructures.OrderByDescending(r => r.Date).First().NewTotalTerms;
            }

            LoanRestructureHistory = new LoanRestructureHistoryDataModel
            {
                LoanID = loansData.LoanID,
                PreviousTermAmount = previousTermAmount,
                PreviousTotalTerms = previousTotalTerms,
                DisabledTerms = 1,
                Date = DateTime.Now,
                PreviousInstallments = new List<LoanRestructureInstallmentsHistoryDataModel>()
            };

            foreach (var li in loansData.LoanInstallments)
            {
                LoanRestructureHistory.PreviousInstallments.Add(new LoanRestructureInstallmentsHistoryDataModel
                {
                    Amount = li.Amount,
                    DueAmount = li.DueAmount,
                    DueDate = li.DueDate,
                    LoanInstallmentID = li.LoanInstallmentID,
                    SubPeriodID = li.SubPeriodID
                });
            }
        }

        public Result<List<LoanTransactionsDto>> PreviewRestructure(int loanID)
        {
            try
            {
                var loanDomain = _loansRepo.GetLoanDomain(loanID);
                loanDomain.RestructureLoan();

                MapInstallmentsToTransactionDto(loanDomain);

                return Result<List<LoanTransactionsDto>>.Success(LoansTransactionDto);
            }
            catch (BaseDomainException ex)
            {
                return Result<List<LoanTransactionsDto>>.Failure(ex.Message);
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<List<LoanTransactionsDto>>.Failure("Hubo un error no manejado.");
            }
        }

        private void MapInstallmentsToTransactionDto(LoanDomain loanDomain)
        {
            var pendingInstallments = loanDomain.LoanInstallments
                .Where(li => li.IsPaid == false)
                .ToList();

            foreach (var pendingIns in pendingInstallments)
            {
                var loanTransactionDto = new LoanTransactionsDto
                {
                    Amount = pendingIns.Amount.CordobaFormat(),
                    DueAmount = pendingIns.DueAmount,
                    DueAmountDisplay = pendingIns.DueAmount.CordobaFormat(),
                    SubPeriodName = pendingIns.PeriodName,
                    LoanInstallmentID = pendingIns.LoanInstallmentID,
                    DueDate = pendingIns.DueDate,
                    TransactionType = LoanTransactionType.Installment
                };

                LoansTransactionDto.Add(loanTransactionDto);
            }
        }
    }
}
