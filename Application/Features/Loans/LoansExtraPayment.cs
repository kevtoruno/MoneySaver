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
            var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(extraPaymentDto.PayDate);

            int subPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0;

            if (subPeriodID <= 0)
                return Result<bool>.Failure("No existe un subperiodo para la fecha seleccionada.");

            var defaultCompany = _moneySaverRepo.GetDefaultCompany();

            var loandDomain = _loansRepo.GetLoanDomain(extraPaymentDto.LoanID);

            loandDomain.Company = defaultCompany;
            loandDomain.MakeExtraPayment(extraPaymentDto.Amount, extraPaymentDto.PayDate, subPeriodID);

            var result = _loansRepo.UpdateLoanWithCompany(loandDomain);

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
