using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.SavingAccount
{
    public class SavingAccountDomainCreator : SavingAccountDomainAggregate
    {
        public SavingAccountDomainCreator(string beneficiaryNames, string beneficiaryLastNames, 
            string beneficiaryPhoneNumber, string beneficiaryRelationship, string beneficiaryAddress)
        {
            BeneficiaryNames = beneficiaryNames;
            BeneficiaryLastNames = beneficiaryLastNames;
            BeneficiaryPhoneNumber = beneficiaryPhoneNumber;
            BeneficiaryRelationship = beneficiaryRelationship;
            BeneficiaryAddress = beneficiaryAddress;
        }

        public void CreateNewSavingAccountForClient(int clientID)
        {
            this.ClientID = clientID;
            CreatedDate = DateTime.Now;
            Amount = 0;
            AmountForInterests = 0;
            IsActive = true;
            CreatedBy = 0;
        }
    }
}
