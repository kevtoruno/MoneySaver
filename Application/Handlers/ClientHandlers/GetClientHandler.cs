using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class GetClientForEditQuery : IRequest<ClientToCreateDto>
{
    public int ClientID { get; set; }
}

public class GetClientHandler : IRequestHandler<GetClientForEditQuery, ClientToCreateDto>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetClientHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<ClientToCreateDto> Handle(GetClientForEditQuery request, CancellationToken cancellationToken)
    {
        var clientToList = new ClientToList(_moneySaverRepo);
        var clientToEdit = clientToList.GetClientForEdit(request.ClientID);

        return Task.FromResult(clientToEdit);
    }
}

