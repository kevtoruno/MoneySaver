﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Loans
{
    public class LoanDomainCreator : LoanDomain
    {    
        public List<SubPeriodDomain> SubPeriods { get; internal set; }
        public LoanInterestsDomain DefaultLoanInterest { get; set; }
        public LoanDomainCreator(int clientID, string description, int totalTerms, 
            decimal loanAmount, LoanInterestsDomain loanInterest,   DateTime startDate, DateTime endDate, string guarantorFullName
            ,string guarantorWorkArea, string guarantorINSSNo, decimal guarantorBaseIncome, string guarantorAddress, string ckCode
            , CompanyDomain company) : base()
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
                Company.DecreaseCurrentAmount(Amount);
                Company.AddFloatingAmount(Amount);
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
            TermAmount = LoanAmount / TotalTerms;
            this.CreatedDate = StartDate.AddMonths(-1);
            this.IsCurrent = true;
            this.PaperCost = DefaultLoanInterest.LoanPaperCost;
        }

        private void CreateLoanInstallments()
        {
            int installCounter = 0;
            foreach (var subPeriod in SubPeriods.OrderBy(a => a.StartDate))
            {
                installCounter++;

                if (installCounter > TotalTerms)
                    break;

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

            if (installCounter < TotalTerms)
                throw new Exception("Error interno al crear cuotas, no existen subperíodos suficientes que cubran el rango del préstamo " + this.CKCode);
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
}
