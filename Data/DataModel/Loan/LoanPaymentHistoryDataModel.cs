using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataModel.Loan
{
    public class LoanPaymentHistoryDataModel
    {
        [Key]
        public int LoanHistoryID { get; set; }
        public int LoanID { get; set; }
        public LoansDataModel Loan { get; set; }
        public int? SubPeriodID { get; set; }
        public SubPeriodsDataModel SubPeriod { get; set; }

        [Column(TypeName="money")]
        public decimal Amount { get; set; }
        public bool IsExtraPayment { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }
    }
}
