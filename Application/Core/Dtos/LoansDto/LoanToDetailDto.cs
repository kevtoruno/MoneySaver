using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class LoanToDetailDto
    {
        public int LoanID { get; set; }
        public string ClientFullName { get; set; } = "";
        public string INSS { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Amount of money asked for the Client.
        /// </summary>
        public string LoanAmount { get; set; }
        public string Amount { get; set; }

        public string Interests { get; set; }
        /// <summary>
        /// Sum of the loan amount asked for the client + interests.
        /// </summary>
        public string DueAmount { get; set; }
        public string TermAmount { get; set; }
        public string TotalTerms { get; set; }
        public bool IsCurrent { get; set; }
        public List<LoanInstallmentsDto> Installments { get; set; }

        public LoanToDetailDto()
        {
            Installments = new List<LoanInstallmentsDto>();
        }
    }

    public class LoanInstallmentsDto
    {
        public int LoanInstallmentID { get; set; }
        public string SubPeriodName { get; set; }
        public string Amount { get; set; }
        public decimal DueAmount { get; set; }
        public string DueAmountDisplay { get { return DueAmount.CordobaFormat(); } }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }
        public string DueDateDisplay { get { return DueDate.ToShortDateString(); } }
    }
}
