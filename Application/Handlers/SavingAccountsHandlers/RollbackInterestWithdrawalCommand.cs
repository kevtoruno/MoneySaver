using MediatR;
using Service.Core;
using Service.Core.Interfaces;
using Service.Core.Interfaces.UnitsOfWork;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class RollbackInterestWithdrawalCommand : IRequest<Result<bool>>
{
    public int SavingAccountID { get; set; }
    public int SavingAccountWithdrawalID { get; set; }
}

internal class RollbackInterestWithdrawalHandler : IRequestHandler<RollbackInterestWithdrawalCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ISavingAccountUnitOfWork _savingAccountUnitOfWork;

    public RollbackInterestWithdrawalHandler(ISavingAccountUnitOfWork savingAccountUnitOfWork)
    {
        //_moneySaverRepo = moneySaverRepo;
        _savingAccountUnitOfWork = savingAccountUnitOfWork;
    }

    public Task<Result<bool>> Handle(RollbackInterestWithdrawalCommand request, CancellationToken cancellationToken)
    {
        var saRollBackInterestWithdrawal = new SavingAccountRollbackInterestWithdrawal(_savingAccountUnitOfWork);

        var result = saRollBackInterestWithdrawal.RollbackInterestWithdrawal(request.SavingAccountID, request.SavingAccountWithdrawalID);

        return Task.FromResult(result);
    }
}
