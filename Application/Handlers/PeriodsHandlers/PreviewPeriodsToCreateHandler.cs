using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Periods;

namespace Service.Handlers.PeriodsHandlers;

public class PreviewPeriodToCreateQuery : IRequest<Result<PeriodToCreateDto>>
{
    public int Year { get; set; }
}

internal class PreviewPeriodsToCreateHandler : 
    IRequestHandler<PreviewPeriodToCreateQuery, Result<PeriodToCreateDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public PreviewPeriodsToCreateHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<PeriodToCreateDto>> Handle(PreviewPeriodToCreateQuery request, CancellationToken cancellationToken)
    {
        var periodsCreator = new PeriodsCreator(_moneySaverRepo);
        var result = periodsCreator.GeneratePeriodToCreateDto(request.Year);

        return Task.FromResult(result);
    }
}
