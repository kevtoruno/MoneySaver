using Domain.Entities;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
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
        private int SubPeriodID = 0;

        public SavingAccountDepositsAdd(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<bool> AddDepositToSavingAccount(SADepositToCreateDto sADepositToCreateDto)
        {
            var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(sADepositToCreateDto.CreatedDate);

            SubPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0;

            if (SubPeriodID <= 0)
                return Result<bool>.Failure("No existe un subperiodo para la fecha seleccionada.");

            bool checkIfDepositExists = _moneySaverRepo.CheckIfDepositExistsForSubPeriod(SubPeriodID, sADepositToCreateDto.SavingAccountID);

            if (checkIfDepositExists)
                return Result<bool>.Failure("Ya se ha hecho un deposito para este subperiodo.");

            var SADomain = _moneySaverRepo.GetSavingAccountDomain(sADepositToCreateDto.SavingAccountID);

            if (SADomain.IsActive == false)
                return Result<bool>.Failure("Este fondo de ahorro no está activo.");

            SADomain.AddDeposit(sADepositToCreateDto.Amount, sADepositToCreateDto.CreatedDate, SubPeriodID, sADepositToCreateDto.InterestsAmount);

            var result = _moneySaverRepo.AddDepositToSavingAccount(SADomain);

            if (result)
                return Result<bool>.Created(true, "Se ha agregado el deposito correctamente.");

            return Result<bool>.Failure("Hubo un error al agregar el deposito.");
        }              
    }
}
