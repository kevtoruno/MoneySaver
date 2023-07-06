using Domain.Entities;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts
{
    public class SavingAccountDepositsAdd
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public SavingAccountDepositsAdd(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> AddDepositToSavingAccount(int savingAccountID, int subPeriodID, 
            decimal depositAmount, DateTime createdDate, decimal interestsAmount)
        {
            if (subPeriodID <= 0)
                return Result<bool>.Failure("No se ha seleccionado un subperiodo.");

            bool checkIfDepositExists = _moneySaverRepo.CheckIfDepositExistsForSubPeriod(subPeriodID, savingAccountID);

            if (checkIfDepositExists)
                return Result<bool>.Failure("Ya se ha hecho un deposito para este subperiodo.");

            var savingAccountData = _moneySaverRepo.GetSavingAccountDetail(savingAccountID);

            var SADomain = new SavingAccountDomainAggregate(savingAccountData.SavingAccountID, savingAccountData.Amount, 
                savingAccountData.AmountForInterests, savingAccountData.IsActive, savingAccountData.ClientID, 
                savingAccountData.CreatedDate);

            if (SADomain.IsActive == false)
                return Result<bool>.Failure("Esta cuenta bancaria no está activa.");

            SADomain.AddDeposit(depositAmount, createdDate, subPeriodID, interestsAmount);

            var result = _moneySaverRepo.AddDepositToSavingAccount(SADomain);

            if (result)
                return Result<bool>.Created(true, "Se ha agregado el deposito de ahorro correctamente.");

            return Result<bool>.Failure("Hubo un error al agregar el deposito.");
            
        }        
    }
}
