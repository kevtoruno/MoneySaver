using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions
{
    internal class FundlessSavingAccountException : Exception
    {
        public FundlessSavingAccountException() : base("No existen fondos a retirar")
        {
            
        }
    }
}
