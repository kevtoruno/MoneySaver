using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    public class LoanPayInstallment
    {
        private readonly ILoansRepository _loansRepo;
        private readonly IMoneySaverRepository _moneySaverRepo;

        public LoanPayInstallment(ILoansRepository loansRepo, IMoneySaverRepository moneySaverRepo)
        {
            _loansRepo = loansRepo;
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> PayInstallment(LoanPayInstallmentDto loanPayInstallmentDto)
        {
            try
            {
                var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(loanPayInstallmentDto.PayDate);

                int subPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0;

                if (subPeriodID <= 0)
                    return Result<bool>.Failure("No existe un subperiodo para la fecha seleccionada.");

                var defaultCompany = _moneySaverRepo.GetDefaultCompany();

                var loandDomain = _loansRepo.GetLoanDomain(loanPayInstallmentDto.LoanID);
                loandDomain.Company = defaultCompany;

                loandDomain.PayInstallment(loanPayInstallmentDto.LoanInstallmentID, subPeriodID, loanPayInstallmentDto.PayDate);

                var result = _loansRepo.UpdateLoanWithCompany(loandDomain);

                if (result)
                    return Result<bool>.Created(true, "Se ha pagado la cuota exitosamente.");

                return Result<bool>.Failure("Hubo un error al pagar.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex.Message);
            }
        }
    }
}
