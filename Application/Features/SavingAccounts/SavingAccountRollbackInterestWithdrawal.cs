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
    public class SavingAccountRollbackInterestWithdrawal
    {
        private readonly ISavingAccountUnitOfWork _savingAccountUnitOfWork;

        public SavingAccountRollbackInterestWithdrawal(ISavingAccountUnitOfWork savingAccountUnitOfWork)
        {
            _savingAccountUnitOfWork = savingAccountUnitOfWork;
        }

        public Result<bool> RollbackInterestWithdrawal(int savingAccountID,int savingAccountWithdrawalID)
        {
            try
            {
                var SADomain = _savingAccountUnitOfWork.GetSavingAccountDomain(savingAccountID, includeTransactionalHistory: true);

                SADomain.RollbackInterestWithdrawal(savingAccountWithdrawalID);

                bool dbResult = _savingAccountUnitOfWork.UpdateSavingAccount(SADomain);

                if (dbResult)
                    return Result<bool>.Created(true, "Se ha anulado el retiro de intereses.");

                return Result<bool>.Failure("Hubo un error al anular el retiro de intereses.");
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
