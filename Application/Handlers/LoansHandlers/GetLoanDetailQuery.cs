using AutoMapper;
using MediatR;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.LoansHandlers;

public class GetLoanDetailQuery : IRequest<LoanToDetailDto>
{
    public int SelectedLoanID { get; set; }
}
internal class GetLoanDetailHandler : IRequestHandler<GetLoanDetailQuery, LoanToDetailDto>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public GetLoanDetailHandler(ILoansRepository loansRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _mapper = mapper;
    }
    public Task<LoanToDetailDto> Handle(GetLoanDetailQuery request, CancellationToken cancellationToken)
    {
        var LoanList = new LoansList(_loansRepo, _mapper);

        var loanDetail = LoanList.GetLoanDetail(request.SelectedLoanID);
        
        return Task.FromResult(loanDetail);
    }
}
