using Service.Core.Dtos;
using Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Reports
{
    public class SavingAccountToDetailReport
    {
        public string ClientFullName { get; set; } = "";
        public string INSS { get; set; }
        public string Identification { get; set; }

        public string Amount { get; set; }
        public string AmountForInterests { get; set; }
        public string TotalWithdrawn { get; set; }
        public string TotalAmount { get; set; }

        public List<SavingAccountsHistoryToListReport> History { get; set; }

        public SavingAccountToDetailReport()
        {
            History = new List<SavingAccountsHistoryToListReport>();
        }
    }

    public class SavingAccountsHistoryToListReport
    {
        public string SubPeriodName { get; set; }
        public decimal Amount { get; set; }
        public string AmountDisplay { get { return Amount.CordobaFormat(); } }
        public string HistoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TotalDisplay { get { return Total.CordobaFormat(); } }
        public decimal Total { get; set; }
    }
}
