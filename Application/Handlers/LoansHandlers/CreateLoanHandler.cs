using MediatR;
using Service.Core.Dtos.LoansDto;
using Service.Core.Dtos;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Service.Core.Interfaces;
using Service.Features.Loans;

namespace Service.Handlers.LoansHandlers;

public class CreateLoanCommand : IRequest<Result<bool>>
{
    public LoanToCreateDto LoanToCreateDto { get; set; }
}

internal class CreateLoanHandler : IRequestHandler<CreateLoanCommand, Result<bool>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly IMapper _mapper;

    public CreateLoanHandler(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _moneySaverRepo = moneySaverRepo;
        _mapper = mapper;
    }

    public Task<Result<bool>> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
    {
        var loanCreator = new LoansCreator(_loansRepo, _moneySaverRepo, _mapper);
        var result = loanCreator.CreateLoan(request.LoanToCreateDto);

        return Task.FromResult(result);
    }
}

