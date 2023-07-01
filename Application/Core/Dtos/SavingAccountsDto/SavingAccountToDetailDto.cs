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

        public List<SavingAccountWidthdrawalsToListDto> WidthdrawalsToList { get; set; }
        public List<SavingAccountDepositsToListDto> DepositsToList { get; set; }
        public SavingAccountToDetailDto()
        {
            WidthdrawalsToList = new List<SavingAccountWidthdrawalsToListDto>();
            DepositsToList = new List<SavingAccountDepositsToListDto>();
        }
    }

    public class SavingAccountWidthdrawalsToListDto
    {
        public int SavingAccountWithdrawalID { get; set; }
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; }

        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class SavingAccountDepositsToListDto
    {
        public int SavingAccountDepositID { get; set; }
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; }

        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
