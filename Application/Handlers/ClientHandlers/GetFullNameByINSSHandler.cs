using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Handlers.SavingAccountsHandlers;
using Service.Core.Interfaces;
using Service.Features.Periods;

namespace Service.Handlers.ClientHandlers;

public class GetFullNameByINSSQuery : IRequest<string>
{
    public string INSSNo { get; set; }
}

internal class GetFullNameByINSSHandler : IRequestHandler<GetFullNameByINSSQuery, string>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetFullNameByINSSHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<string> Handle(GetFullNameByINSSQuery request, CancellationToken cancellationToken)
    {
        var savingAccountCreator = new SavingAccountCreator(_moneySaverRepo);

        string clietFullName = savingAccountCreator.GetFullNameByINSS(request.INSSNo);

        return Task.FromResult(clietFullName);
    }
}
