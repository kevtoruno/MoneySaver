using MediatR;
using Service.Core;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Features.Loans;
using Service.Handlers.LoansHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class ExtraPaymentCommand : IRequest<Result<bool>>
{
    public LoanExtraPaymentDto LoanExtraPaymentDto { get; set; }    
}

internal class ExtraPaymentHandler : IRequestHandler<ExtraPaymentCommand, Result<bool>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMoneySaverRepository _moneySaverRepo;

    public ExtraPaymentHandler(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo)
    {
        _loansRepo = loansRepo;
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(ExtraPaymentCommand request, CancellationToken cancellationToken)
    {
        var loanExtraPayment = new LoansExtraPayment(_loansRepo, _moneySaverRepo);
        var result = loanExtraPayment.ExtraPayment(request.LoanExtraPaymentDto);

        return Task.FromResult(result);
    }
}
