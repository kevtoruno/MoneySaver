using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;

namespace Service.Handlers;

public class GenerateMonthlyLoanPaymentsPreviewQuery : IRequest<Result<List<MonthlyLoanPaymentsForPreviewDto>>>
{
    public DateTime Date { get; set; }
    public string Path { get; set; }
}

internal class GenerateMonthlyLoanPaymentsPreviewHandler : 
    IRequestHandler<GenerateMonthlyLoanPaymentsPreviewQuery, Result<List<MonthlyLoanPaymentsForPreviewDto>>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepository;

    public GenerateMonthlyLoanPaymentsPreviewHandler(IMoneySaverRepository moneySaverRepo, 
        ILoansRepository loansRepository)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepository = loansRepository;
    }

    public Task<Result<List<MonthlyLoanPaymentsForPreviewDto>>> Handle(GenerateMonthlyLoanPaymentsPreviewQuery request, CancellationToken cancellationToken)
    {
        var monthlyPayments = new LoansMonthlyPaymentsPreviewGenerator(_moneySaverRepo, _loansRepository);

        var result = monthlyPayments.GenerateMonthlyPaymentsForPreview(request.Path, request.Date);

        return Task.FromResult(result);
    }
}

