using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos;

public class PeriodsToListDto
{
    public int PeriodID { get; set; }
    public int Year { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string PeriodName { get 
        {
            return "Período " + Year.ToString();
        } }
}
