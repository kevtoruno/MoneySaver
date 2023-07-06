using Domain.Entities;
using Domain.Entities.SavingAccount;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Periods
{
    public class SavingAccountCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public SavingAccountCreator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> CreateSavingAccount(int ClientID) 
        {
            var savingAccountExists = _moneySaverRepo.CheckIfClientHasActiveSavingAccount(ClientID);

            if (savingAccountExists) 
                return Result<bool>.Failure("Este trabajador ya tiene una cuenta de ahorro activa");

            var savingAccountDomain = new SavingAccountDomainCreator();
            savingAccountDomain.CreateNewSavingAccountForClient(ClientID);

            var savingAccountToCreate = new SavingAccountToCreate
            {
                ClientID = savingAccountDomain.ClientID,
                Amount = savingAccountDomain.Amount,
                AmountForInterests = savingAccountDomain.AmountForInterests,
                IsActive = savingAccountDomain.IsActive,
                CreatedBy = savingAccountDomain.CreatedBy,
                CreatedDate = savingAccountDomain.CreatedDate
            };

            _moneySaverRepo.CreateSavingAccount(savingAccountToCreate);

            return Result<bool>.Created(true, "La cuenta de ahorro ha sido creada exitosamente.");
        }
    }
}
