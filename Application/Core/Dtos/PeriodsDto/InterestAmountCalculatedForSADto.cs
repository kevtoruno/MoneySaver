using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.PeriodsDto
{
    public class InterestAmountCalculatedForSADto
    {
        public int SavingAccountID { get; set; }
        public string ClientFullName { get; set; }
        public string INSSNo { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public string TotalDepositAmountDisplay { get => TotalDepositAmount.CordobaFormat(); }
        public decimal InterestGeneratedAmount { get; set; }
        public string InterestGeneratedAmountDisplay { get => InterestGeneratedAmount.CordobaFormat(); }
    }
}
