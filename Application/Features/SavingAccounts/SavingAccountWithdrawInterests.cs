﻿using Service.Core.Dtos;
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
        private int SubPeriodID = 0;
        public SavingAccountWithdrawInterests(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> WithdrawInterestsFromSavingAccount(int savingAccountID, DateTime withdrawDate)
        {
            try
            {
                var validationResult = WithdrawInterestsValidation(savingAccountID, withdrawDate);

                if (validationResult.IsSucess == false)
                    return validationResult;

                var SADomain = _moneySaverRepo.GetSavingAccountDomain(savingAccountID);

                SADomain.WithdrawInterests(withdrawDate, SubPeriodID);

                bool result = _moneySaverRepo.WithdrawInterestsSavingAccount(SADomain);

                if (result)
                    return Result<bool>.Created(true, "Se han retirado intereses correctamente.");

                return Result<bool>.Failure("Hubo un error al retirar intereses.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex.Message);
            }  
        }

        private Result<bool> WithdrawInterestsValidation(int savingAccountID, DateTime withdrawDate)
        {
            var latestWithdrawalDate = _moneySaverRepo.GetLatestWithdrawDateForSavingAccountID(savingAccountID);

            if (latestWithdrawalDate > withdrawDate)
                return Result<bool>.Failure("Ya existe un retiro más próximo a la fecha seleccionada.");

            var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(withdrawDate);

            SubPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0;

            if (SubPeriodID <= 0)
                return Result<bool>.Failure("No existe un subperiodo para la fecha seleccionada.");

            bool checkIfWithdrawExists = _moneySaverRepo.CheckIfInterestWithdrawExistsForSubPeriod(SubPeriodID, savingAccountID);

            if (checkIfWithdrawExists)
                return Result<bool>.Failure("Ya se ha retirado intereses para este periodo.");

            return Result<bool>.Success(true);
        }
    }
}
