using Service.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class LoansToListDto
    {
        public int LoanID { get; set; }
        public string INSSNo { get; set; }
        public string ClientFullName { get; set; }
        public string Description { get; set; }
        public string LoanAmount { get; set; }
        public string DueAmount { get; set; }
        public DateTime EndDate { get; set; }
        public string EndDateToDisplay { get => EndDate.ToShortDateString(); }
        public bool IsCurrent { get; set; }
        public string CKCode { get; set; }
    }
}
