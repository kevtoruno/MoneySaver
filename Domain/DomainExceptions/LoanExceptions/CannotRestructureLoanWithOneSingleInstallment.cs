using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.LoanExceptions;

internal class CannotRestructureLoanWithOneSingleInstallment : BaseDomainException
{
    public CannotRestructureLoanWithOneSingleInstallment() : base("No se puede reestructurar un préstamo con una cuota pendiente.")
    {
        
    }
}

