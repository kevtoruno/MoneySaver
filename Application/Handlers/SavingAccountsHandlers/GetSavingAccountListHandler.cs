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
using Service.Features.SavingAccounts;

namespace Service.Handlers;

public class GetSavingAccountListQuery : IRequest<List<SavingAccountToListDto>>
{
    public string INSSNo { get; set; }
}

internal class GetSavingAccountListHandler :
    IRequestHandler<GetSavingAccountListQuery, List<SavingAccountToListDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetSavingAccountListHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<List<SavingAccountToListDto>> Handle(GetSavingAccountListQuery request, CancellationToken cancellationToken)
    {
        var savingAccountsListService = new SavingAccountList(_moneySaverRepo);

        var savingAccountData = savingAccountsListService.GetSavingAccountsList(request.INSSNo);

        return Task.FromResult(savingAccountData);
    }
}
