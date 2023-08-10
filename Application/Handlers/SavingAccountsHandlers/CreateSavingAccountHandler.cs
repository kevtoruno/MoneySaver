using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Periods;

namespace Service.Handlers.SavingAccountsHandlers;

public class CreateSavingAccountCommand : IRequest<Result<int>>
{
    public SavingAccountToCreateDto SavingAccountToCreateDto { get; set; }
}

internal class CreateSavingAccountHandler : IRequestHandler<CreateSavingAccountCommand, Result<int>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public CreateSavingAccountHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<int>> Handle(CreateSavingAccountCommand request, CancellationToken cancellationToken)
    {
        var savingAccountCreator = new SavingAccountCreator(_moneySaverRepo);

        var result = savingAccountCreator.CreateSavingAccount(request.SavingAccountToCreateDto);

        return Task.FromResult(result);
    }
}
