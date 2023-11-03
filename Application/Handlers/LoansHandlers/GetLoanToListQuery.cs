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

public class GetLoanToListQuery : IRequest<List<LoansToListDto>>
{
    public string INSS { get; set; }
}
internal class GetLoanToListHandler : IRequestHandler<GetLoanToListQuery, List<LoansToListDto>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public GetLoanToListHandler(ILoansRepository loansRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<List<LoansToListDto>> Handle(GetLoanToListQuery request, CancellationToken cancellationToken)
    {
        var loansService = new LoansList(_loansRepo, _mapper);

        var loansData = loansService.GetLoansList(request.INSS);

        return Task.FromResult(loansData);
    }
}
