using AutoMapper;
using MediatR;
using Service.Core;
using Service.Core.Interfaces;
using Service.Features.Loans;
using Service.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers.LoansHandlers;

public class CreateMonthlyLoansPaymentsCommand : IRequest<Result<bool>>
{
    public DateTime SubPeriodDate { get; set; }
    public DateTime Date { get; set; }
    public string Path { get; set; }
}

internal class CreateMonthlyLoansPaymentsHandler : IRequestHandler<CreateMonthlyLoansPaymentsCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;
    private readonly ILoansRepository _loansRepo;
    private readonly IMapper _mapper;

    public CreateMonthlyLoansPaymentsHandler(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo, IMapper mapper)
    {
        _moneySaverRepo = moneySaverRepo;
        _loansRepo = loansRepo;
        _mapper = mapper;
    }

    public Task<Result<bool>> Handle(CreateMonthlyLoansPaymentsCommand request, CancellationToken cancellationToken)
    {
        var paymentsCreator = new LoansMonthlyPaymentCreator(_moneySaverRepo, _loansRepo, _mapper);

        var result = paymentsCreator.CreateMonthlyPayments(request.Path, request.Date, request.SubPeriodDate);

        return Task.FromResult(result);
    }
}
