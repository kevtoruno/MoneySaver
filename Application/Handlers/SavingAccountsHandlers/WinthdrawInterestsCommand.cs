using MediatR;
using Service.Core.Dtos;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Handlers;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;

namespace Service.Handlers;

public class WinthdrawInterestsCommand : IRequest<Result<bool>>
{
    public int SavingAccountID { get; set; }
    public DateTime CreatedDate { get; set; }
}

public class WindrawInterestsHandler : IRequestHandler<WinthdrawInterestsCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public WindrawInterestsHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<Result<bool>> Handle(WinthdrawInterestsCommand request, CancellationToken cancellationToken)
    {
        var saWinthdrawInterests = new SavingAccountWithdrawInterests(_moneySaverRepo);

        var result = saWinthdrawInterests.WithdrawInterestsFromSavingAccount(request.SavingAccountID, request.CreatedDate);

        return Task.FromResult(result);
    }
}
