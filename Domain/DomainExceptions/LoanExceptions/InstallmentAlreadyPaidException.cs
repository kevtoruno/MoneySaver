using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.LoanExceptions;

internal class InstallmentAlreadyPaidException : Exception
{
    public InstallmentAlreadyPaidException() : base("La cuota seleccionada ya está pagada")
    {
        
    }
}
