using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions
{
    internal class NoInterestsToWithdrawException : Exception
    {
        public NoInterestsToWithdrawException(): base("No existen intereses a retirar.")
        {
            
        }
    }
}
