using Domain.Entities;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos;
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

        public Result<bool> AddDepositToSavingAccount(SADepositToCreateDto sADepositToCreateDto)
        {
            if (sADepositToCreateDto.SubPeriodID <= 0)
                return Result<bool>.Failure("No se ha seleccionado un subperiodo.");

            bool checkIfDepositExists = _moneySaverRepo.CheckIfDepositExistsForSubPeriod(sADepositToCreateDto.SubPeriodID, sADepositToCreateDto.SavingAccountID);

            if (checkIfDepositExists)
                return Result<bool>.Failure("Ya se ha hecho un deposito para este subperiodo.");

            var SADomain = _moneySaverRepo.GetSavingAccountDomain(sADepositToCreateDto.SavingAccountID);

            if (SADomain.IsActive == false)
                return Result<bool>.Failure("Este fondo de ahorro no está activo.");

            SADomain.AddDeposit(sADepositToCreateDto.Amount, sADepositToCreateDto.CreatedDate, sADepositToCreateDto.SubPeriodID, sADepositToCreateDto.InterestsAmount);

            var result = _moneySaverRepo.AddDepositToSavingAccount(SADomain);

            if (result)
                return Result<bool>.Created(true, "Se ha agregado el deposito de ahorro correctamente.");

            return Result<bool>.Failure("Hubo un error al agregar el deposito.");
        }        
    }
}
