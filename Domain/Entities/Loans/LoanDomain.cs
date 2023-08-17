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
        public CompanyDomain Company { get; set; }
        public LoanInterestsDomain DefaultLoanInterest { get; set; }
        public int CreatedBy { get; set; }
        public string CKCode { get; set; }
        public string Description { get; set; }
        public int TotalTerms { get; set; }
        /// <summary>
        /// Amount of money asked for the Client.
        /// </summary>
        public decimal LoanAmount { get; set; }

        public decimal Interests { get; set; }
        /// <summary>
        /// Amount to give the customer to.
        /// This amount equals LoanAmount - interests - papercost decreased.
        /// </summary>
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public decimal TermAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCurrent { get; set; }
        public decimal PaperCostAmount { get; set; }
        public string GuarantorFullName { get; set; }
        public string GuarantorWorkArea { get; set; }
        public string GuarantorINSSNo { get; set; }
        public decimal GuarantorBaseIncome { get; set; }
        public string GuarantorAddress { get; set; }
        public List<SubPeriodDomain> SubPeriods { get; private set; }
        public List<LoanInstallmentsDomain> LoanInstallments { get; private set; }

        public LoanDomain(int clientID, string description, int totalTerms, 
            decimal loanAmount, LoanInterestsDomain loanInterest,   DateTime startDate, DateTime endDate, string guarantorFullName
            ,string guarantorWorkArea, string guarantorINSSNo, decimal guarantorBaseIncome, string guarantorAddress, string ckCode
            , CompanyDomain company)
        {
            DefaultLoanInterest = loanInterest;
            ClientID = clientID;
            Description = description;
            TotalTerms = totalTerms;
            LoanAmount = loanAmount;
            StartDate = startDate;
            EndDate = endDate;
            LoanInterestID = loanInterest.LoanInterestID;
            GuarantorAddress = guarantorAddress;
            GuarantorBaseIncome = guarantorBaseIncome;
            GuarantorFullName = guarantorFullName;
            GuarantorINSSNo = guarantorINSSNo;
            GuarantorWorkArea = guarantorWorkArea;
            LoanInstallments = new List<LoanInstallmentsDomain>();
            CKCode = ckCode;
            Company = company;
        }

        public void CreateLoan(List<SubPeriodDomain> subPeriods)
        {
            try
            {
                SubPeriods = subPeriods;
                SetBaseLoanValues();
                Company.DecreaseCurrentAmount(LoanAmount);
                Company.AddFloatingAmount(LoanAmount);
                CreateLoanInstallments();  
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetBaseLoanValues()
        {
            Interests = LoanAmount * (DefaultLoanInterest.InterestRate / 100);
            Amount = LoanAmount - Interests - DefaultLoanInterest.LoanPaperCost;
            DueAmount = LoanAmount;
            TermAmount = LoanAmount / TotalTerms;
            this.CreatedDate = DateTime.Now;
            this.IsCurrent = true;
            this.PaperCostAmount = DefaultLoanInterest.LoanPaperCost;
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
                    DueDate = dueDate,
                    PeriodName = subPeriod.SubPeriodName,
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
        public string PeriodName { get; set; }
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }
    }
}
