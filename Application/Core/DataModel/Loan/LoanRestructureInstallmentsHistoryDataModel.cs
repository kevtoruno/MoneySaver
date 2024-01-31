using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel.Loan
{
    public class LoanRestructureInstallmentsHistoryDataModel
    {
        [Key]
        public int LoanRestructureInstallmentsHistoryID { get; set; }

        public int LoanRestructureHistoryID { get; set; }
        public LoanRestructureHistoryDataModel LoanRestructureHistory { get; set; }
        public int LoanInstallmentID { get; set; }
        public int SubPeriodID { get; set; }
        public SubPeriodsDataModel SubPeriod { get; set; }

        [Column(TypeName="money")]
        public decimal Amount { get; set; }
        [Column(TypeName="money")]
        public decimal DueAmount { get; set; }
        public DateTime DueDate { get; set; }
    }
}
