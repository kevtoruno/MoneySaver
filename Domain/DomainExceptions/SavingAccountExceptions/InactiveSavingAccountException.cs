using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions
{
    public class InactiveSavingAccountException : Exception
    {
        public InactiveSavingAccountException() : base("Este fondo de ahorro no está activo")
        {
            
        }
    }
}
