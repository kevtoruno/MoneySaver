using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.LoanExceptions
{
    internal class AmountIsNotMultipleWithTermAmount: Exception
    {
        public AmountIsNotMultipleWithTermAmount(decimal termAmount) : base("La cantidad ingresada debe ser multiplo de "+termAmount)
        {
            
        }
    }
}
