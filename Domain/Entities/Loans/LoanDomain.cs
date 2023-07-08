using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Loans
{
    public class LoanDomain
    {
        public int ClientID { get; set; }
        public int LoanInterestID { get; set; }
        public LoanInterestsDomain LoanInterest { get; set; }
        public int CreatedBy { get; set; }
        public string Description { get; set; }
        public int TotalTerms { get; set; }
        /// <summary>
        /// Amount of money asked for the Client.
        /// </summary>
        public decimal LoanAmount { get; set; }

        public decimal Interests { get; set; }
        /// <summary>
        /// Sum of the loan amount asked for the client + interests.
        /// </summary>
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public decimal TermAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCurrent { get; set; }
        public List<SubPeriodDomain> SubPeriods { get; private set; }
        public List<LoanInstallmentsDomain> LoanInstallments { get; private set; }

        public LoanDomain(int clientID, string description, int totalTerms, decimal loanAmount, DateTime startDate, DateTime endDate)
        {
            ClientID = clientID;
            Description = description;
            TotalTerms = totalTerms;
            LoanAmount = loanAmount;
            StartDate = startDate;
            EndDate = endDate;
            LoanInstallments = new List<LoanInstallmentsDomain>();
        }

        public void CreateLoan(List<SubPeriodDomain> subPeriods, decimal interestRate)
        {
            SubPeriods = subPeriods;
            SetBaseLoanValues(interestRate);

            CreateLoanInstallments();
        }

        private void SetBaseLoanValues(decimal interestRate)
        {
            Interests = LoanAmount * (interestRate / 100);
            Amount = Interests + LoanAmount + 6;
            DueAmount = Amount;
            TermAmount = Amount / TotalTerms;
        }

        private void CreateLoanInstallments()
        {
            foreach (var subPeriod in SubPeriods.OrderBy(a => a.StartDate))
            {
                DateTime dueDate = CalculateDueDateForPeriod(subPeriod.StartDate.Year, subPeriod.Month);

                LoanInstallments.Add(new LoanInstallmentsDomain
                {
                    Amount = TermAmount,
                    DueAmount = TermAmount,
                    IsPaid = false,
                    SubPeriodID = subPeriod.SubPeriodID,
                    DueDate = dueDate
                });
            }
        }

        private DateTime CalculateDueDateForPeriod(int periodYear, int periodMonth)
        {
            DateTime dueDate;

            if (StartDate.Day > 28)
            {
                int daysInPeriodMonth = DateTime.DaysInMonth(periodYear, periodMonth);

                dueDate = new DateTime(periodYear, periodMonth, daysInPeriodMonth);
            }
            else
            {
                dueDate = new DateTime(periodYear, periodMonth, StartDate.Day);
            }

            return dueDate;
        }
    }

    public class LoanInstallmentsDomain
    {
        public int LoanID { get; set; }
        public int SubPeriodID { get; set; }
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }
    }
}
