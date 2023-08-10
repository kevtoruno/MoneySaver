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

public class EditClientCommand : IRequest<Result<bool>>
{
    public ClientToCreateDto ClientToCreateDto { get; set; }
    public EditClientCommand()
    {
        ClientToCreateDto = new ClientToCreateDto();
    }
}

public class EditClientHandler : IRequestHandler<CreateClientCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public EditClientHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {
        var clientCreator = new ClientCreator(_moneySaverRepo);
        var result = clientCreator.EditClient(request.ClientToCreateDto);

        return Task.FromResult(result);
    }
}

