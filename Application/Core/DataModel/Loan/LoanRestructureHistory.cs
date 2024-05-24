using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel.Loan
{
    public class LoanRestructureHistoryDataModel
    {
        [Key]
        public int LoanRestructureHistoryID { get; set; }
        public int LoanID { get; set; }
        public LoansDataModel Loan { get; set; }
        public int PreviousTotalTerms { get; set; }
        public int NewTotalTerms { get; set; }

        [Column(TypeName="money")]
        public decimal PreviousTermAmount { get; set; }

        [Column(TypeName="money")]
        public decimal NewTermAmount { get; set; }
        public int DisabledTerms { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<LoanRestructureInstallmentsHistoryDataModel> PreviousInstallments { get; set; }
    }
}
