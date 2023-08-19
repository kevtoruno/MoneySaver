using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class SavingAccountToDetailDto
    {
        public int SavingAccountID { get; set; }
        public string ClientFullName { get; set; } = "";
        public string INSS { get; set; }
        public string Identification { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string Amount { get; set; }
        public string AmountForInterests { get; set; }
        public string TotalWithdrawn { get; set; }
        public string TotalAmount { get; set; }
        public string Beneficiary { get; set; }

        public List<SavingAccountsHistoryToListDto> SavingAccountsHistoryToList { get; set; }
        public SavingAccountToDetailDto()
        {
            SavingAccountsHistoryToList = new List<SavingAccountsHistoryToListDto>();
        }
    }

    public class SavingAccountsHistoryToListDto 
    {
        public int SavingAccountHistoryID { get; set; }
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; }
        public decimal Amount { get; set; }
        public string AmountDisplay { get { return Amount.CordobaFormat(); } }
        public SavingAccountHistoryType HistoryType { get; set; }
        public string HistoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TotalDisplay { get { return Total.CordobaFormat(); } }
        public decimal Total { get; set; }
    }

    public enum SavingAccountHistoryType 
    {
        Deposit = 0,
        InterestsWithdrawn = 1,
        FullWithdrawn = 2,
        InterestDeposit = 3
    }
}
