using Domain.DomainExceptions.LoanExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Loans
{
    public class LoanInstallmentsDomain
    {
        public int LoanInstallmentID { get; set; }
        public int LoanID { get; set; }
        public int SubPeriodID { get; set; }
        public string PeriodName { get; set; }
        public decimal Amount { get; set; }
        public decimal DueAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DatePaid { get; set; }

        /// <summary>
        /// Depending on the input amount, either partially or fully pay the installment
        /// then returns the remaining amount if any.
        /// </summary>
        public decimal PayAmount(decimal amount, DateTime date)
        {
            decimal remainingAmount = 0;

            if (amount >= DueAmount)
            {
                remainingAmount = amount - DueAmount;
                FullPay(date);
            }
            else
                PartialPay(amount);

            return remainingAmount;
        }

        public void FullPay(DateTime date)
        {
            if(DueAmount <= 0 || IsPaid == true)
                throw new InstallmentAlreadyPaidException();

            DueAmount = 0;
            IsPaid = true;
            DatePaid = date.Date;
        }

        private void PartialPay(decimal amount)
        {
            if (DueAmount <= 0 || IsPaid == true)
                throw new InstallmentAlreadyPaidException();

            DueAmount -= amount;
        }
    }
}
