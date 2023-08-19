using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using Service.Features.Periods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.PeriodsHandlers;

public class GetPeriodsListQuery : IRequest<List<PeriodsToListDto>>
{

}
internal class GetPeriodsListHandler : IRequestHandler<GetPeriodsListQuery, List<PeriodsToListDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetPeriodsListHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<List<PeriodsToListDto>> Handle(GetPeriodsListQuery request, CancellationToken cancellationToken)
    {
        var periodToList = new PeriodsToList(_moneySaverRepo);

        var periodsList = periodToList.GetPeriodsList();

        return Task.FromResult(periodsList);
    }
}
