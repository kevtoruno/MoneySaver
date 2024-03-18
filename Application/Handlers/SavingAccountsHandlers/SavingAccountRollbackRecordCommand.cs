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

public class SavingAccountRollbackRecordCommand : IRequest<Result<bool>>
{
    public int SavingAccountID { get; set; }
    public int SavingAccountWithdrawalID { get; set; }
    public int RecordType { get; set; }
}

internal class SavingAccountRollbackRecordHandler : IRequestHandler<SavingAccountRollbackRecordCommand, Result<bool>>
{
    private readonly ISavingAccountUnitOfWork _savingAccountUnitOfWork;

    public SavingAccountRollbackRecordHandler(ISavingAccountUnitOfWork savingAccountUnitOfWork)
    {
        _savingAccountUnitOfWork = savingAccountUnitOfWork;
    }

    public Task<Result<bool>> Handle(SavingAccountRollbackRecordCommand request, CancellationToken cancellationToken)
    {
        var saRollBackInterestWithdrawal = new SavingAccountRollbackRecord(_savingAccountUnitOfWork);

        var result = saRollBackInterestWithdrawal.RollbackInterestWithdrawal(request.SavingAccountID, 
            request.SavingAccountWithdrawalID, request.RecordType);

        return Task.FromResult(result);
    }
}
