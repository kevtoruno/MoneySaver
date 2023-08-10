using MediatR;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class GetClientListQuery : IRequest<List<ClientToListDto>>
{
    public string INSS { get; set; }
}

public class GetClientListHandler : IRequestHandler<GetClientListQuery, List<ClientToListDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetClientListHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<List<ClientToListDto>> Handle(GetClientListQuery request, CancellationToken cancellationToken)
    {
        var clientToList = new ClientToList(_moneySaverRepo);
        var cllientsListDto = clientToList.GetClientsList(request.INSS);

        return Task.FromResult(cllientsListDto);
    }
}

