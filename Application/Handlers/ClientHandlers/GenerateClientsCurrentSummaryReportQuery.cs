using MediatR;
using Service.Core;
using Service.Core.Dtos.ClientsDto;
using Service.Core.Interfaces;
using Service.Features.Client;
using Service.Handlers.LoansHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.ClientHandlers;

public class GenerateClientsCurrentSummaryReportQuery : IRequest<Result<ClientsSummaryReportDto>>
{
}

internal class GenerateClientsCurrentSummaryReportHandler : IRequestHandler<GenerateClientsCurrentSummaryReportQuery, Result<ClientsSummaryReportDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;

    public GenerateClientsCurrentSummaryReportHandler(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
    }
    public Task<Result<ClientsSummaryReportDto>> Handle(GenerateClientsCurrentSummaryReportQuery request, CancellationToken cancellationToken)
    {
        var clientsCurrentSummaryReport = new ClientsCurrentSummaryReport(_moneySaverRepo, _loansRepo);
        var result = clientsCurrentSummaryReport.GenerateReportDto();

        return Task.FromResult(result);
    }
}
