using MediatR;
using Service.Core;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class GenerateMonthlyDepositsPreviewQuery : IRequest<Result<List<MonthlyDepositsForPreviewDto>>>
{
    public DateTime Date { get; set; }
    public string Path { get; set; }
}

internal class GenerateMonthlyDepositsPreviewHandler : 
    IRequestHandler<GenerateMonthlyDepositsPreviewQuery, Result<List<MonthlyDepositsForPreviewDto>>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GenerateMonthlyDepositsPreviewHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<List<MonthlyDepositsForPreviewDto>>> Handle(GenerateMonthlyDepositsPreviewQuery request, CancellationToken cancellationToken)
    {
        var saMonthlyPreviewGenerator = new SAMonthlyDepositsPreviewGenerator(_moneySaverRepo);

        var monthlyDepositsPreview = saMonthlyPreviewGenerator.GenerateMonthlyDepositsForPreview(request.Path, request.Date);

        return Task.FromResult(monthlyDepositsPreview);
    }
}
