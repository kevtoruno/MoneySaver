using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class InterestRangesDataModel
    {
        [Key]
        public int InterestRangeID { get; set; }
        public int CompanyID { get; set; }
        public CompaniesDataModel Company { get; set; }

        [Column(TypeName="money")]
        public decimal From { get; set; }

        [Column(TypeName="money")]
        public decimal To { get; set; }
        public decimal Percentage { get; set; }
    }
}
