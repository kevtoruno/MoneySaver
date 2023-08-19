using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Interfaces;
using Service.Features.Periods;

namespace Service.Handlers.PeriodsHandlers;

public class CreatePeriodCommand : IRequest<Result<bool>>
{
    public int Year { get; set; }
    public int CompanyID { get; set; }
}

internal class CreatePeriodsHandler : IRequestHandler<CreatePeriodCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public CreatePeriodsHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(CreatePeriodCommand request, CancellationToken cancellationToken)
    {
        var periodsCreator = new PeriodsCreator(_moneySaverRepo);
        var result = periodsCreator.CreatePeriods(request.Year, request.CompanyID);

        return Task.FromResult(result);
    }
}
