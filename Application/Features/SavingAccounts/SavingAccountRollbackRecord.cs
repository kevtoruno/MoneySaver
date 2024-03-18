using Domain.DomainExceptions;
using Service.Core;
using Service.Core.Interfaces;
using Service.Core.Interfaces.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts
{
    public class SavingAccountRollbackRecord
    {
        private readonly ISavingAccountUnitOfWork _savingAccountUnitOfWork;

        public SavingAccountRollbackRecord(ISavingAccountUnitOfWork savingAccountUnitOfWork)
        {
            _savingAccountUnitOfWork = savingAccountUnitOfWork;
        }

        public Result<bool> RollbackInterestWithdrawal(int savingAccountID,int recordID, int recordType)
        {
            try
            {
                var SADomain = _savingAccountUnitOfWork.GetSavingAccountDomain(savingAccountID, includeTransactionalHistory: true);
                
                SADomain.RollbackRecord(recordID, recordType); 

                bool dbResult = _savingAccountUnitOfWork.UpdateSavingAccount(SADomain);

                if (dbResult)
                    return Result<bool>.Created(true, "Se ha anulado el registro seleccionado.");

                return Result<bool>.Failure("Hubo un error al anular el registro seleccionado.");
            }
            catch (BaseDomainException ex)
            {
                return Result<bool>.Failure(ex.Message);
            }
            catch(Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<bool>.Failure("Error no manejado.");
            }
        }

    }

}
