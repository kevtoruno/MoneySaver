using Service.Core.Dtos;
using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts
{
    public class SavingAccountWithdrawInterests
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public SavingAccountWithdrawInterests(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> WithdrawInterestsFromSavingAccount(int savingAccountID, int subPeriodID, DateTime withdrawDate)
        {
            if (subPeriodID <= 0)
                return Result<bool>.Failure("No se ha seleccionado un subperiodo.");

            bool checkIfWithdrawExists = _moneySaverRepo.CheckIfInterestWithdrawExistsForSubPeriod(subPeriodID, savingAccountID);

            if (checkIfWithdrawExists)
                return Result<bool>.Failure("Ya se ha retirado intereses para este periodo.");

            var SADomain = _moneySaverRepo.GetSavingAccountDomain(savingAccountID);

            if (SADomain.IsActive == false)
                return Result<bool>.Failure("Este fondo de ahorro no está activo.");

            if (SADomain.AmountForInterests == 0)
                return Result<bool>.Failure("No existen intereses a retirar.");

            SADomain.WithdrawInterests(withdrawDate, subPeriodID);

            bool result = _moneySaverRepo.WithdrawInterestsSavingAccount(SADomain);

            if (result)
                return Result<bool>.Created(true, "Se han retirado intereses correctamente.");

            return Result<bool>.Failure("Hubo un error al retirar intereses.");
        }
    }
}
