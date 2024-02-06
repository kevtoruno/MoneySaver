using AutoMapper;
using Domain.Entities;
using Service.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Mapping
{
    public class SavingAccountMapping
    {
        private readonly IMapper _mapper;

        public SavingAccountMapping(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void MapDomainToDataModel(SavingAccountDomainAggregate saDomain, 
            SavingAccountsDataModel saDataModel)
        {
            MapBaseSavingAccountValues(saDomain, saDataModel); 
            
            AddNewWithdrawals(saDomain, saDataModel);   

            RemoveDeletedWithdrawals(saDomain, saDataModel);
        }

        private void RemoveDeletedWithdrawals(SavingAccountDomainAggregate saDomain, 
            SavingAccountsDataModel saDataModel)
        {
            foreach (var withdrawalDataModel in saDataModel.Withdrawals)
            {
                bool withdrawalExists = saDomain.Withdrawals
                    .Any(wdom => wdom.SavingAccountWithdrawalID == withdrawalDataModel.SavingAccountWithdrawalID);

                if (withdrawalExists == false)
                {
                    saDataModel.Withdrawals.Remove(withdrawalDataModel);
                }
            }
        }

        private void MapBaseSavingAccountValues(SavingAccountDomainAggregate saDomain, 
            SavingAccountsDataModel saDataModel)
        {
            saDataModel.ClosedDate = saDomain.ClosedDate;
            saDataModel.CreatedDate = saDomain.CreatedDate;
            saDataModel.CreatedBy = saDomain.CreatedBy;
            saDataModel.BeneficiaryRelationship = saDomain.BeneficiaryRelationship;
            saDataModel.BeneficiaryPhoneNumber = saDomain.BeneficiaryPhoneNumber;
            saDataModel.BeneficiaryLastNames = saDomain.BeneficiaryLastNames;
            saDataModel.BeneficiaryAddress = saDomain.BeneficiaryAddress;
            saDataModel.BeneficiaryNames = saDomain.BeneficiaryNames;
            saDataModel.Amount = saDomain.Amount;
            saDataModel.AmountForInterests = saDomain.AmountForInterests;
            saDataModel.IsActive = saDomain.IsActive;
        }

        private void AddNewWithdrawals(SavingAccountDomainAggregate saDomain, 
            SavingAccountsDataModel saDataModel)
        {
            foreach (var withdrawalDomain in saDomain.Withdrawals)
            {
                bool withdrawalExists = saDataModel.Withdrawals
                    .Any(sdm => sdm.SavingAccountWithdrawalID == withdrawalDomain.SavingAccountWithdrawalID);

                if (withdrawalExists == false)
                {
                    var withdrawalDataModel = _mapper.Map<SavingAccountWidthdrawalsDataModel>(withdrawalDomain);

                    saDataModel.Withdrawals.Add(withdrawalDataModel);
                }
            } 
        }
    }
}
