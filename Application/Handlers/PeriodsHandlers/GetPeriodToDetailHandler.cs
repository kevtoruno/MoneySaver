using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
using Service.Core.Interfaces;
using Service.Features.Periods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.PeriodsHandlers;

public class GetPeriodToDetailQuery : IRequest<Result<PeriodsToDetailDto>>
{
    public int PeriodID { get; set; }
}

internal class GetPeriodToDetailHandler : IRequestHandler<GetPeriodToDetailQuery, Result<PeriodsToDetailDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;

    public GetPeriodToDetailHandler(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
    }
    public Task<Result<PeriodsToDetailDto>> Handle(GetPeriodToDetailQuery request, CancellationToken cancellationToken)
    {
        var periodToDetail = new PeriodsToDetail(_moneySaverRepo, _loansRepo);

        var periodsDto = periodToDetail.GetPeriodToDetail(request.PeriodID);

        return Task.FromResult(periodsDto);
    }
}
