using AutoMapper;
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

public class GetCurrentInterestFactorForSubPeriodQuery : IRequest<Result<SubPeriodInterestsCalculationDto>>
{
    public int SubPeriodID { get; set; }
}

public class GetCurrentInterestFactorForSubPeriodHandler : IRequestHandler<GetCurrentInterestFactorForSubPeriodQuery, Result<SubPeriodInterestsCalculationDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public GetCurrentInterestFactorForSubPeriodHandler(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo
        ,IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<Result<SubPeriodInterestsCalculationDto>> Handle(GetCurrentInterestFactorForSubPeriodQuery request, CancellationToken cancellationToken)
    {
        var subPeriodCalculateMonthlyFactor = new SubPeriodInterestAmountCalculator(_moneySaverRepo, _loansRepo, _mapper);

        var monthlyFactorDto = subPeriodCalculateMonthlyFactor.GetCurrentInterestFactorForSubPeriod(request.SubPeriodID);

        return Task.FromResult(monthlyFactorDto);
    }
}
