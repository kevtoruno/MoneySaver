using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions
{
    internal class DateIsNotTheLatestSavingAccountException : Exception
    {
        public DateIsNotTheLatestSavingAccountException() : base("La fecha seleccionada es menor a otras transacciones realizadas en este fondo de ahorro.")
        {
            
        }
    }
}
