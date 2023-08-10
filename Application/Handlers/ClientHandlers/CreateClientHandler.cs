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

public class CreateClientCommand : IRequest<Result<bool>>
{
    public ClientToCreateDto ClientToCreateDto { get; set; }
    public CreateClientCommand()
    {
        ClientToCreateDto = new ClientToCreateDto();
    }
}

public class CreateClientHandler : IRequestHandler<CreateClientCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public CreateClientHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        var clientCreator = new ClientCreator(_moneySaverRepo);
        var result = clientCreator.CreateNewClient(request.ClientToCreateDto);

        return Task.FromResult(result);
    }
}

