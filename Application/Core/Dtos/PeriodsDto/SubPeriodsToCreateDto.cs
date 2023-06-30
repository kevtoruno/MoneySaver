using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class SubPeriodsToCreateDto
    {
        public int SubPeriodID { get; set; }
        public int PeriodID { get; set; }
        public int Month { get; set; }  
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string MonthName 
        { 
            get 
            {
                return StartDate.ToString("MMM");
            }
        }
    }
}
