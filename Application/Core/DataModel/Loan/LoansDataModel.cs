using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class LoansDataModel
    {
        [Key]
        public int LoanID { get; set; }
        public int ClientID { get; set; }
        public ClientsDataModel Client { get; set; }
        public int LoanInterestID { get; set; }
        public LoanInterestsDataModel LoanInterest { get; set; }
        public string GuarantorFullName { get; set; }
        public string GuarantorWorkArea { get; set; }
        public string GuarantorINSSNo { get; set; }
        [Column(TypeName="money")]
        public decimal GuarantorBaseIncome { get; set; }
        public string GuarantorAddress { get; set; }

        public string CKCode { get; set; }
        public int CreatedBy { get; set; }
        public string Description { get; set; }
        public int TotalTerms { get; set; }
        /// <summary>
        /// Amount of money asked for the Client.
        /// </summary>

        [Column(TypeName="money")]
        public decimal LoanAmount { get; set; }

        [Column(TypeName="money")]
        public decimal Interests { get; set; }
        /// <summary>
        /// Sum of the loan amount asked for the client + interests.
        /// </summary>
        [Column(TypeName="money")]
        public decimal Amount { get; set; }
        [Column(TypeName="money")]
        public decimal DueAmount { get; set; }
        [Column(TypeName="money")]
        public decimal TermAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCurrent { get; set; }

        public ICollection<LoanInstallmentsDataModel> LoanInstallments { get; set; }
        public ICollection<LoanPaymentHistoryDataModel> LoanPaymentHistories { get; set; }
    }
}
