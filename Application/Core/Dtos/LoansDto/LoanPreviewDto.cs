using Domain.Entities.Loans;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.LoansDto
{
    public class LoanPreviewDto
    {
        public string ClientFullname { get; set; }
        public decimal LoanInterestRate { get; set; }
        public int TotalTerms { get; set; }
        /// <summary>
        /// Amount of money asked for the Client.
        /// </summary>
        public decimal LoanAmount { get; set; }

        public string Interests { get; set; }
        /// <summary>
        /// Sum of the loan amount asked for the client + interests.
        /// </summary>
        public string Amount { get; set; }
        public string TermAmount { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string PaperCostAmount { get; set; }
        public List<LoanInstallmentsPreviewDto> LoanInstallments { get; private set; }

        public LoanPreviewDto()
        {
            LoanInstallments = new List<LoanInstallmentsPreviewDto>();   
        }
    }

    public class LoanInstallmentsPreviewDto
    {
        public string PeriodName { get; set; }
        public string Amount { get; set; }
        public string DueDate { get; set; }
    }
}
