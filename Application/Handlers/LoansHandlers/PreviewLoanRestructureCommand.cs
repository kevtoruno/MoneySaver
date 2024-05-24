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

public class PreviewLoanRestructureCommand : IRequest<Result<List<LoanTransactionsDto>>>
{
    public int LoanID { get; set; }
}

internal class PreviewLoanRestructureHandler : IRequestHandler<PreviewLoanRestructureCommand, Result<List<LoanTransactionsDto>>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public PreviewLoanRestructureHandler(ILoansRepository loansRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _mapper = mapper;
    }
    public Task<Result<List<LoanTransactionsDto>>> Handle(PreviewLoanRestructureCommand request, CancellationToken cancellationToken)
    {
        var loanRestructure = new LoanRestructure(_loansRepo, _mapper);

        var result = loanRestructure.PreviewRestructure(request.LoanID);

        return Task.FromResult(result);
    }
}
