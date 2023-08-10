using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class MonthlyDepositsFromPDFDto
    {
        public string INSSNo { get; set; }
        public decimal Amount { get; set; }
    }
}
