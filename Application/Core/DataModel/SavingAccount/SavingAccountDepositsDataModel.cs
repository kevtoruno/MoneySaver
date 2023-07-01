using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class SavingAccountDepositsDataModel
    {
        [Key]
        public int SavingAccountDepositID { get; set; }
        public int SavingAccountID { get; set; }
        public SavingAccountsDataModel SavingAccount { get; set; }
        public int SubPeriodID { get; set; }
        public SubPeriodsDataModel SubPeriod { get; set; }

        [Column(TypeName="money")]
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
