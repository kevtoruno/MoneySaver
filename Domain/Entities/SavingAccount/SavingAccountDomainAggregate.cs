using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SavingAccountDomainAggregate
    {
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountForInterests { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CreatedBy { get; set; }
        public List<SavingAccountDepositDomain> Deposits { get; set; }
        public List<SavingAccountWithdrawsDomain> Withdraws { get; set; }

        public SavingAccountDomainAggregate(int savingAccountID, decimal amount, decimal amountForInterests, 
            bool isActive, int clientID, DateTime createdDate)
        {
            SavingAccountID = savingAccountID;
            Amount = amount;
            AmountForInterests = amountForInterests;
            IsActive = isActive;
            Deposits = new List<SavingAccountDepositDomain>();
            Withdraws = new List<SavingAccountWithdrawsDomain>();
            ClientID = clientID;
            CreatedDate = createdDate;
        }

        public SavingAccountDomainAggregate()
        {
            Deposits = new List<SavingAccountDepositDomain>();
            Withdraws = new List<SavingAccountWithdrawsDomain>();
        }
        
        public void WithdrawInterests(DateTime withdrawDate, int subPeriodID)
        {
            if (this.AmountForInterests <= 0)
                return;

            if (withdrawDate.Month == 6 || withdrawDate.Month == 12)
            {
                Withdraws.Add(new SavingAccountWithdrawsDomain
                {
                    Amount = this.AmountForInterests,
                    SavingAccountID = this.SavingAccountID,
                    CreatedDate = withdrawDate,
                    SubPeriodID = subPeriodID,
                    WithdrawType = 0 //Interests
                });
     
                this.Amount -= AmountForInterests;
                this.AmountForInterests = 0;
            }
        }

        public void AddDeposit(decimal depositAmount, DateTime depositDate, 
            int subPeriodID, decimal interestsAmount) 
        {
            if (IsActive == false)
                return;

            Amount += depositAmount;

            Deposits.Add(new SavingAccountDepositDomain
            {
                Amount = depositAmount,
                SavingAccountID = this.SavingAccountID,
                CreatedDate = depositDate,
                SubPeriodID = subPeriodID,
                DepositType = 0 //Saving
            });

            AddInterestIfMonthJuneOrDecember(interestsAmount, depositDate, subPeriodID);
        }

        private void AddInterestIfMonthJuneOrDecember(decimal interestsAmount, DateTime depositDate, 
            int subPeriodID) 
        {
            if (depositDate.Month == 6 || depositDate.Month == 12)
            {
                Amount += interestsAmount;
                AmountForInterests += interestsAmount;

                Deposits.Add(new SavingAccountDepositDomain
                {
                    Amount = interestsAmount,
                    SavingAccountID = this.SavingAccountID,
                    CreatedDate = depositDate,
                    SubPeriodID = subPeriodID,
                    DepositType = 1 //Interests
                });
            }
        }
    }

    public class SavingAccountDepositDomain
    { 
        public int SavingAccountID { get; set; }
        public int SubPeriodID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DepositType { get; set; }
    }

    public class SavingAccountWithdrawsDomain
    { 
        public int SavingAccountID { get; set; }
        public int SubPeriodID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int WithdrawType { get; set; } //Interests 0, Close account 1
    }
}
