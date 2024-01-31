using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainExceptions.SavingAccountExceptions
{
    internal class WithdrawalIsNotTheLatest : BaseDomainException
    {
        public WithdrawalIsNotTheLatest() : base("Unicamente puede eliminar el retiro de intereses mas reciente.")
        {
        }
    }
}
