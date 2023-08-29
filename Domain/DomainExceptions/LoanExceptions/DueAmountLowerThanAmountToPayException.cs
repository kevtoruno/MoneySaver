using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.LoanExceptions;

internal class AmountToPayHigherThanDueAmountException : Exception
{
    public AmountToPayHigherThanDueAmountException() : base("La cantidad ingresada es mayor a la cantidad pendiente.")
    {
        
    }
}

