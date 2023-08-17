using MediatR;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Service.Core.Interfaces;
using Service.Features.SavingAccounts;

namespace Service.Handlers;

public class CreateMonthlyDepositsCommand: IRequest<Result<bool>>
{
    public DateTime Date { get; set; }
    public string Path { get; set; }
}

internal class CreateMonthlyDepositsHandler : IRequestHandler<CreateMonthlyDepositsCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly IMapper _mapper;

    public CreateMonthlyDepositsHandler(IMoneySaverRepository moneySaverRepo, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _mapper = mapper;
    }
    public Task<Result<bool>> Handle(CreateMonthlyDepositsCommand request, CancellationToken cancellationToken)
    {
        var saMonthlyDepositsCreator = new SavingAccountMonthlyDepositsCreator(_moneySaverRepo, _mapper);
        var result = saMonthlyDepositsCreator.CreateMonthlyDeposits(request.Path, request.Date);

        return Task.FromResult(result);
    }
}
