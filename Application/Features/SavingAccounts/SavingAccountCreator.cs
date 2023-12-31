﻿using Domain.Entities;
using Domain.Entities.SavingAccount;
using iText.StyledXmlParser.Css.Selector.Item;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.LoansDto;
using Service.Core.Interfaces;
using Service.Core.Validators;
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
        private int ClientID = 0;

        public SavingAccountCreator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public Result<int> CreateSavingAccount(SavingAccountToCreateDto SavingAccountToCreate) 
        {
            ClientID = _moneySaverRepo.GetClientIDByINSSNo(SavingAccountToCreate.INSSNo);

            var DBValidationsResult = SetDataFromDBAndValidate(SavingAccountToCreate);

            if (DBValidationsResult.IsSucess == false)
                return DBValidationsResult;

            var savingAccountDomain = new SavingAccountDomainCreator(SavingAccountToCreate.BeneficiaryNames, 
                SavingAccountToCreate.BeneficiaryLastNames, SavingAccountToCreate.BeneficiaryPhoneNumber, 
                SavingAccountToCreate.BeneficiaryRelationship, SavingAccountToCreate.BeneficiaryAddress);

            savingAccountDomain.CreateNewSavingAccountForClient(ClientID);

            int saCreatedID = _moneySaverRepo.CreateSavingAccount(savingAccountDomain);

            return Result<int>.Created(saCreatedID, "El fondo de ahorro ha sido creada exitosamente.");
        }

        private Result<int> SetDataFromDBAndValidate(SavingAccountToCreateDto SavingAccountToCreate)
        {
            ClientID = _moneySaverRepo.GetClientIDByINSSNo(SavingAccountToCreate.INSSNo);

           if (ClientID == 0) 
                return Result<int>.Failure($"No existe un afiliado asociado al número de INSS {SavingAccountToCreate.INSSNo}"); 
        
            var savingAccToCreateValidator = new SavingAccountToCreateValidator();
            var dtoValidationErros = savingAccToCreateValidator.Validate(SavingAccountToCreate).Errors;
            
            if (dtoValidationErros.Count > 0)
                return Result<int>.Failure(dtoValidationErros.First().ErrorMessage);

            int savingAccountExists = _moneySaverRepo.CheckIfClientHasSavingAccount(ClientID);

            if (savingAccountExists == 1) 
                return Result<int>.Failure("Este afiliado ya tiene un fondo de ahorro actualmente activo.");
            else if(savingAccountExists == 2)    
                return Result<int>.Failure("Este afiliado ya tiene un fondo de ahorro historico pero está cerrado, " +
                    "debe volver a abrirlo manualmente.");

            return Result<int>.Success(0);
        }

        public string GetFullNameByINSS(string INSSNo)
        {
            var fullName = _moneySaverRepo.GetFullNameByINSS(INSSNo);

            return fullName;
        }
    }
}
