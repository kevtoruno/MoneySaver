using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.SavingAccountExceptions
{
    internal class InvalidMonthToWithdrawInterestsException : Exception
    {
        public InvalidMonthToWithdrawInterestsException() : base("Unicamente se puede retirar intereses en los meses de Junio y Diciembre.")
        {
            
        }
    }
}
