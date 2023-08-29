using Service.Core.Dtos;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.Dtos.LoansDto;

namespace Service.Features.Loans;

internal class LoansExtraPayment
{
    private readonly ILoansRepository _loansRepo;
    private readonly IMoneySaverRepository _moneySaverRepo;

    public LoansExtraPayment(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo)
    {
        _loansRepo = loansRepo;
        _moneySaverRepo = moneySaverRepo;
    }

    public Result<bool> ExtraPayment(LoanExtraPaymentDto extraPaymentDto)
    {
        try
        {
            var defaultCompany = _moneySaverRepo.GetDefaultCompany();

            var loandDomain = _loansRepo.GetLoanDomain(extraPaymentDto.LoanID);

            loandDomain.Company = defaultCompany;
            loandDomain.MakeExtraPayment(extraPaymentDto.Amount, extraPaymentDto.PayDate);

            var result = _loansRepo.UpdateLoan(loandDomain);

            if (result)
                return Result<bool>.Created(true, "Pago extraordinario realizado exitosamente.");

            return Result<bool>.Failure("Hubo un error al pagar.");
        }
        catch (Exception ex)
        {
            return Result<bool>.Failure(ex.Message);
        }
    }
}
