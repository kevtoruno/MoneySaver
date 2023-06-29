using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataModel
{
    public class SubPeriodsDataModel
    {
        [Key]
        public int SubPeriodID { get; set; }
        public int PeriodID { get; set; }
        public PeriodsDataModel Period { get; set; }
        public int Month { get; set; }  
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
