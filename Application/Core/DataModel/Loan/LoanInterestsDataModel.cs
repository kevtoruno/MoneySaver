using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class LoanInterestsDataModel
    {
        [Key]
        public int LoanInterestID { get; set; }
        public int CompanyID { get; set; }
        public CompaniesDataModel Company { get; set; }
        public decimal InterestRate { get; set; }
        [Column(TypeName="money")]
        public decimal LoanPaperCost { get; set; }
        public bool IsDefault { get; set; }
    }
}
