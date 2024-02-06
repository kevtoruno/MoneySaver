using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Loans
{
    internal class LoansDeleter
    {
        private readonly ILoansRepository _loansRepo;

        public LoansDeleter(ILoansRepository loansRepo)
        {
            _loansRepo = loansRepo;
        }

        public Result<bool> Delete(int loandID)
        {
            try
            {
                var result = _loansRepo.DeleteLoan(loandID);

                return Result<bool>.Created(true, "Préstamo eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex.Message);
            }
        }
    }
}
