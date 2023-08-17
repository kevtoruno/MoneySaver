using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;

namespace Service.Handlers.SavingAccountsHandlers;

public class ReactivateSavingAccountCommand : IRequest<Result<bool>>
{
    public int SavingAccountID { get; set; }
}

internal class ReactivateSavingAccountHandler : IRequestHandler<ReactivateSavingAccountCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public ReactivateSavingAccountHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(ReactivateSavingAccountCommand request, CancellationToken cancellationToken)
    {
        var savingAccountReActivator = new SavingAccountReActivate(_moneySaverRepo);
        
        var result = savingAccountReActivator.ReActivate(request.SavingAccountID);

        return Task.FromResult(result);
    }
}
