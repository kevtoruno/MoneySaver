using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class LoansForPreviewMassCreationDto
    {
        public string INSSNo { get; set; }
        public int ClientID { get; set; }
        public string ClientFullName { get; set; }

        public string CKCode { get; set; }
        public DateTime Date { get; set; }
        public decimal LoanAmount { get; set; }
        public int TotalInstallments { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }
}
