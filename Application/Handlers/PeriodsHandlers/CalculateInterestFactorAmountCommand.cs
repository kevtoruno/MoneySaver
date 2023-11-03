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

public class CalculateInterestFactorAmountCommand : IRequest<Result<bool>>
{
    public int SubPeriodID { get; set; }
    public int UtilityMonths { get; set; }
    public DateTime DepositDate { get; set; }
}

internal class CalculateInterestFactorAmountHandler : IRequestHandler<CalculateInterestFactorAmountCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public CalculateInterestFactorAmountHandler(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<Result<bool>> Handle(CalculateInterestFactorAmountCommand request, CancellationToken cancellationToken)
    {
        var subPeriodInterestAmountCreator = new SubPeriodMonthlyInterestAmountCreator(_moneySaverRepo, _loansRepo, _mapper);

        var result = subPeriodInterestAmountCreator.CreateMonthlyInterestsAmount(request.SubPeriodID, 
            request.DepositDate, request.UtilityMonths);

        return Task.FromResult(result);
    }
}
