using MediatR;
using Service.Core.Dtos.LoansDto;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Interfaces;
using Service.Features.PDFDataExtractor;
using Service.Features.Loans;
using AutoMapper;

namespace Service.Handlers.LoansHandlers;

public class PreviewLoansForMassCreationQuery : IRequest<Result<List<LoansForPreviewMassCreationDto>>>
{
    public string Path { get; set; }
}

internal class GenerateMonthlyLoanPaymentsPreviewHandler :
    IRequestHandler<PreviewLoansForMassCreationQuery, Result<List<LoansForPreviewMassCreationDto>>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepository;
    private readonly IMapper _mapper;

    public GenerateMonthlyLoanPaymentsPreviewHandler(IMoneySaverRepository moneySaverRepo, 
        ILoansRepository loansRepository, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepository = loansRepository;
        _mapper = mapper;
    }

    public Task<Result<List<LoansForPreviewMassCreationDto>>> Handle(PreviewLoansForMassCreationQuery request, CancellationToken cancellationToken)
    {
        var loanMassCreator = new LoansMassCreator(_moneySaverRepo, _loansRepository);

        var result = loanMassCreator.GenerateLoanMassCreationPreview(request.Path);

        return Task.FromResult(result);
    }
}
