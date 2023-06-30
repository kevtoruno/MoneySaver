using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataModel
{
    public class PeriodsDataModel
    {
        [Key]
        public int PeriodID { get; set; }
        public int? CompanyID { get; set; }
        public CompaniesDataModel Company { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
