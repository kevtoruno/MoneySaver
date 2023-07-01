using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class CompaniesDataModel
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        [Column(TypeName="money")]
        public decimal FloatingAmount { get; set; }

        [Column(TypeName="money")]
        public decimal CurrentAmount { get; set; }
    }
}
