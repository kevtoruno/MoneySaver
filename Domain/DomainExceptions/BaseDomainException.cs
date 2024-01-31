using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions
{
    public class BaseDomainException : Exception
    {
        public BaseDomainException(string errorMsg) : base(errorMsg)
        {
            
        }
    }
}
