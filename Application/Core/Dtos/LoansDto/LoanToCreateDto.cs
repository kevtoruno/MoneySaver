using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class LoanToCreateDto
    {
        public string INSSNo { get; set; }
        public string Description { get; set; }
        public int TotalTerms { get; set; }
        public decimal LoanAmount { get; set; }

        public DateTime StartDate { get; set; }
    }
}
