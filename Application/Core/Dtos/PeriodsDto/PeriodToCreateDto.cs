using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class PeriodToCreateDto
    {
        public int PeriodID { get; set; }
        public int CompanyID { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<SubPeriodsToCreateDto> SubPeriods { get; set; }

        public PeriodToCreateDto()
        {
            SubPeriods = new List<SubPeriodsToCreateDto>();
        }
    }
}
