using MediatR;
using Service.Core;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class FullWithdrawalCommand : IRequest<Result<bool>>
{
    public DateTime Date { get; set; }
    public int SavingAccountID { get; set; }
}

internal class FullWithdrawalHandler : IRequestHandler<FullWithdrawalCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public FullWithdrawalHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<Result<bool>> Handle(FullWithdrawalCommand request, CancellationToken cancellationToken)
    {
        var savingAccountFullWithdrawal = new SavingAccountFullWithdrawal(_moneySaverRepo);
        var result = savingAccountFullWithdrawal.FullWithdrawal(request.SavingAccountID, request.Date);

        return Task.FromResult(result);
    }
}
