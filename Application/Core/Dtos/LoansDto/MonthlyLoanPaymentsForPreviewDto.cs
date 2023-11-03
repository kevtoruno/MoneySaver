using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class MonthlyLoanPaymentsForPreviewDto
    {
        public string ClientFullName { get; set; }
        public int LoanID { get; set; }
        public int LoanInstallmentID { get; set; }
        public string INSSNo { get; set; }
        public decimal PendingAmount { get; set; }
        public string PendingAmountDisplay { get => PendingAmount.CordobaFormat(); }
        public decimal PaymentAmount { get; set; }
        public string PaymentAmountDisplay { get => PaymentAmount.CordobaFormat(); }
        public bool IsValid { get; set; }
        public DateTime Date { get; set; }
        public string ErrorMessage { get; set; }
    }
}
