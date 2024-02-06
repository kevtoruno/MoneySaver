using MediatR;
using Service.Core.Dtos;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Interfaces;
using Service.Features.Loans;

namespace Service.Handlers.LoansHandlers;

public class DeleteLoanCommand : IRequest<Result<bool>>
{
    public int LoanID { get; set; }
}

internal class DeleteLoanHandler : IRequestHandler<DeleteLoanCommand, Result<bool>>
{
    private readonly ILoansRepository _loansRepo;

    public DeleteLoanHandler(ILoansRepository loansRepo)
    {
        _loansRepo = loansRepo;
    }
    public Task<Result<bool>> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
    {
        var loansDeleter = new LoansDeleter(_loansRepo);

        var result = loansDeleter.Delete(request.LoanID);

        return Task.FromResult(result);
    }
}
