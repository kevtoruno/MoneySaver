using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.LoanExceptions;

internal class DueAmountLowerThanAmountToPayException : Exception
{
    public DueAmountLowerThanAmountToPayException() : base("La cantidad pendiente es menor a la cantidad a pagar.")
    {
        
    }
}

