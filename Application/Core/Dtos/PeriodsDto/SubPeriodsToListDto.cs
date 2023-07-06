using Service.Core.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.PeriodsDto
{
    public class SubPeriodsToListDto
    {
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; }
        public int PeriodID { get; set; }
        public int Month { get; set; }  
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
