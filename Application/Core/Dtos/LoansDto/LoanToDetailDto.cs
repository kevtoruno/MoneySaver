using MediatR.NotificationPublishers;
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
        public List<LoanTransactionsDto> TransactionHistory { get; set; }

        public LoanToDetailDto()
        {
            TransactionHistory = new List<LoanTransactionsDto>();
        }
    }

    public class LoanTransactionsDto
    {
        public int LoanInstallmentID { get; set; }
        public LoanTransactionType TransactionType { get; set; }
        public string TransactionTypeString { get 
            {
                if (TransactionType == LoanTransactionType.Installment)
                {
                    return "Cuota";
                }
                else if (TransactionType == LoanTransactionType.InstallmentPayment)
                {
                    return "Pago de cuota";
                }
                else
                {
                    return "Pago extra";
                }
            } }
        public string SubPeriodName { get; set; }
        public string Amount { get; set; }
        public decimal DueAmount { get; set; }
        public string DueAmountDisplay { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public string DueDateDisplay { 
            get 
            {
                if (DueDate == DateTime.MinValue)
                    return "";
                
                return DueDate.ToShortDateString(); 
            } 
        }
        public DateTime DatePaid { get; set; }
        public string DatePaidDisplay { 
            get 
            { 
                if (DatePaid == DateTime.MinValue)
                    return "";
                
                return DatePaid.ToShortDateString(); 
            } 
        }
    }

    public enum LoanTransactionType
    {
        Installment = 0,
        InstallmentPayment = 1,
        ExtraPayment = 2
    }
}
