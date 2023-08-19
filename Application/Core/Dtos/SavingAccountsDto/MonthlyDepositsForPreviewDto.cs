using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.SavingAccountsDto
{
    public class MonthlyDepositsForPreviewDto
    {
        public string ClientFullName { get; set; }
        public int SavingAccountID { get; set; }
        public string INSSNo { get; set; }
        public decimal Amount { get; set; }
        public string AmountDisplay { get => Amount.CordobaFormat(); }
        public bool IsValid { get; set; }
        public DateTime Date { get; set; }
        public string ErrorMessage { get; set; }
    }
}
