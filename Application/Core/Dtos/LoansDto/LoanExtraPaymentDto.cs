using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class LoanExtraPaymentDto
    {
        public int LoanID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PayDate { get; set; }
    }
}
