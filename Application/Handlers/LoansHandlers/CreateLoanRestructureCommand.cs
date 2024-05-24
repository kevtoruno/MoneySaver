using AutoMapper;
using MediatR;
using Service.Core;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.LoansHandlers;

public class CreateLoanRestructureCommand : IRequest<Result<bool>>
{
    public int LoanID { get; set; }
}

internal class CreateLoanRestructureHandler : IRequestHandler<CreateLoanRestructureCommand, Result<bool>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public CreateLoanRestructureHandler(ILoansRepository loansRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _mapper = mapper;
    }
    public Task<Result<bool>> Handle(CreateLoanRestructureCommand request, CancellationToken cancellationToken)
    {
        var loanRestructure = new LoanRestructure(_loansRepo, _mapper);

        var result = loanRestructure.SaveLoanRestructure(request.LoanID);

        return Task.FromResult(result);
    }
}
