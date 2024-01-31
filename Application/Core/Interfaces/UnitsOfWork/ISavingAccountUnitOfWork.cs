using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Interfaces.UnitsOfWork
{
    public interface ISavingAccountUnitOfWork
    {
        SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID, bool includeTransactionalHistory = false);

        bool UpdateSavingAccount(SavingAccountDomainAggregate saDomain);
    }
}
