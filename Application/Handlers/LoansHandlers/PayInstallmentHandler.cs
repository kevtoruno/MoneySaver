using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.LoansHandlers;

public class PayInstallmentCommand : IRequest<Result<bool>>
{
    public LoanPayInstallmentDto LoanPayInstallmentDto { get; set; }
}

internal class PayInstallmentHandler : IRequestHandler<PayInstallmentCommand, Result<bool>>
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMoneySaverRepository _moneySaverRepo;

    public PayInstallmentHandler(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo)
    {
        _loansRepo = loansRepo;
        _moneySaverRepo = moneySaverRepo;
    }
    public Task<Result<bool>> Handle(PayInstallmentCommand request, CancellationToken cancellationToken)
    {
        var payInstallment = new LoanPayInstallment(_loansRepo, _moneySaverRepo);
        var result = payInstallment.PayInstallment(request.LoanPayInstallmentDto);

        return Task.FromResult(result);
    }
}
