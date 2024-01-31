using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class MonthlyLoanPaymentsForPreviewViewModel
    {
        public int TotalClientsFromPDF { get; set; }
        public string TotalPaymentAmountFromPDF { get; set; }
        public string TotalPendingAmountForSubperiod { get; set; }
        public int ValidPaymentsForProcessing { get; set; }
        public int NotValidPaymentsForProcessing { get; set; }
        public List<MonthlyLoanPaymentsForPreviewDto> MonthlyPaymentsForPreview { get; set; }

        public MonthlyLoanPaymentsForPreviewViewModel()
        {
            MonthlyPaymentsForPreview = new List<MonthlyLoanPaymentsForPreviewDto>();    
        }
    }
}
