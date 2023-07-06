using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.SavingAccount
{
    public class SavingAccountDomainCreator : SavingAccountDomainAggregate
    {
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
