using Service.Core;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features
{
    internal class SavingAccountBeneficiary
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public SavingAccountBeneficiary(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<BeneficiaryToEditDto> GetBenenficiaryDetail(int savingAccountID)
        {
            var savingAccountData = _moneySaverRepo.GetSavingAccountDetail(savingAccountID);

            if (savingAccountData == null)
                return Result<BeneficiaryToEditDto>.Failure("No se encontro fondo de ahorro");

            var beneficiaryDto = new BeneficiaryToEditDto
            {
                SavingAccountID = savingAccountID,
                BeneficiaryAddress = savingAccountData.BeneficiaryAddress,
                BeneficiaryLastNames = savingAccountData.BeneficiaryLastNames,
                BeneficiaryNames = savingAccountData.BeneficiaryNames,
                BeneficiaryPhoneNumber = savingAccountData.BeneficiaryPhoneNumber,
                BeneficiaryRelationship = savingAccountData.BeneficiaryRelationship
            };

            return Result<BeneficiaryToEditDto>.Success(beneficiaryDto);
        }

        public Result<bool> EditSavingAccountBeneficiary(BeneficiaryToEditDto beneficiaryToEditDto)
        {
            var savingAccountDomain = _moneySaverRepo.GetSavingAccountDomain(beneficiaryToEditDto.SavingAccountID);

            if (savingAccountDomain == null)
                return Result<bool>.Failure("No se encontró un fondo de ahorro");

            savingAccountDomain.BeneficiaryAddress = beneficiaryToEditDto.BeneficiaryAddress;
            savingAccountDomain.BeneficiaryLastNames = beneficiaryToEditDto.BeneficiaryLastNames;
            savingAccountDomain.BeneficiaryNames = beneficiaryToEditDto.BeneficiaryNames;
            savingAccountDomain.BeneficiaryPhoneNumber = beneficiaryToEditDto.BeneficiaryPhoneNumber;
            savingAccountDomain.BeneficiaryRelationship = beneficiaryToEditDto.BeneficiaryRelationship;

            var result = _moneySaverRepo.UpdateSavingAccount(savingAccountDomain);

            if (result == false)
                return Result<bool>.Failure("Hubo un error al editar la información del beneficiario");

            return Result<bool>.Created(result, "Se ha modificado al beneficiario correctamente.");
        }
    }
}
