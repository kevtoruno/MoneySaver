using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.PeriodsDto
{
    public class PeriodsToDetailDto
    {
        public int PeriodID { get; set; }
        public string PeriodName { get; set; } = string.Empty;
        public int Year { get; set; }

        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;

        public List<SubPeriodsDetailToListDto> SubPeriods { get; set; }

        public PeriodsToDetailDto()
        {
            SubPeriods = new List<SubPeriodsDetailToListDto>();
        }
    }

    public class SubPeriodsDetailToListDto
    {
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; } = string.Empty;
        public int PeriodID { get; set; }
        public int Month { get; set; }  
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TotalIncomeDisplay { get => TotalIncome.CordobaFormat(); }
        public string TotalOutcomeDisplay { get => TotalOutcome.CordobaFormat(); }
        public decimal TotalIncome { get; set; }
        public decimal TotalOutcome { get; set; }
    }
}
