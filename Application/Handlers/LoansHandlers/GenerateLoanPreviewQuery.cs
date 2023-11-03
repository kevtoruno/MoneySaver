using AutoMapper;
using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.LoansHandlers;

public class GenerateLoanPreviewQuery : IRequest<Result<LoanPreviewDto>>
{
    public LoanToCreateDto LoanToCreateDto { get; set; }
}

internal class PreviewLoanHandler : 
    IRequestHandler<GenerateLoanPreviewQuery, Result<LoanPreviewDto>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly IMapper _mapper;

    public PreviewLoanHandler(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo, IMapper mapper)
    {
        _loansRepo = loansRepo;
        _moneySaverRepo = moneySaverRepo;
        _mapper = mapper;
    }

    public Task<Result<LoanPreviewDto>> Handle(GenerateLoanPreviewQuery request, CancellationToken cancellationToken)
    {
        var loanCreator = new LoansCreator(_loansRepo, _moneySaverRepo, _mapper);
        var result = loanCreator.PreviewLoan(request.LoanToCreateDto);

        return Task.FromResult(result);
    }
}
