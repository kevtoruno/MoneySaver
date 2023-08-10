using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class AddDepositCommand : IRequest<Result<bool>>
{
    public SADepositToCreateDto DepositToCreateDto { get; set; }
}

internal class AddDepositHandler: IRequestHandler<AddDepositCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public AddDepositHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(AddDepositCommand request, CancellationToken cancellationToken)
    {
        var savingAccountDepositsToAdd = new SavingAccountDepositsAdd(_moneySaverRepo); 

        var result = savingAccountDepositsToAdd.AddDepositToSavingAccount(request.DepositToCreateDto);

        return Task.FromResult(result);
    }
}
