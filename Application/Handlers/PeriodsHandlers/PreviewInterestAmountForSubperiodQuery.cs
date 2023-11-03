using MediatR;
using Service.Core.Dtos.PeriodsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Interfaces;
using Service.Features.Periods;
using AutoMapper;

namespace Service.Handlers.PeriodsHandlers;

public class PreviewInterestAmountForSubperiodQuery : IRequest<Result<SubPeriodInterestsCalculationDto>>
{
    public int SubPeriodID { get; set; }
    public int UtilityMonths { get; set; }
    public DateTime DepositDate { get; set; }
}

public class PreviewInterestAmountForSubperiodQueryHandler : IRequestHandler<PreviewInterestAmountForSubperiodQuery, Result<SubPeriodInterestsCalculationDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public PreviewInterestAmountForSubperiodQueryHandler(IMoneySaverRepository moneySaverRepo, 
        ILoansRepository loansRepo, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<Result<SubPeriodInterestsCalculationDto>> Handle(PreviewInterestAmountForSubperiodQuery request, CancellationToken cancellationToken)
    {
        var subPeriodCalculateMonthlyFactor = new SubPeriodInterestAmountCalculator(_moneySaverRepo, _loansRepo, _mapper);

        var monthlyFactorDto = subPeriodCalculateMonthlyFactor.PreviewInterestAmountsForSavingAccounts(request.SubPeriodID, request.UtilityMonths, request.DepositDate);

        return Task.FromResult(monthlyFactorDto);
    }
}


