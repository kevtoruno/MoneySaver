
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class LoanInstallmentsDataModel
    {
        [Key]
        public int LoanInstallmentID { get; set; }
        public int LoanID { get; set; }
        public LoansDataModel Loan { get; set; }
        public int SubPeriodID { get; set; }
        public SubPeriodsDataModel SubPeriod { get; set; }
        [Column(TypeName="money")]
        public decimal Amount { get; set; }
        [Column(TypeName="money")]
        public decimal DueAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DatePaid { get; set; }
    }
}
