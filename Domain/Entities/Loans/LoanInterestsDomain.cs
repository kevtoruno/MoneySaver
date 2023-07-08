using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Loans
{
    public class LoanInterestsDomain
    {
        public int LoanInterestID { get; set; }
        public int CompanyID { get; set; }
        public decimal InterestRate { get; set; }
        public bool IsDefault { get; set; }
    }
}
