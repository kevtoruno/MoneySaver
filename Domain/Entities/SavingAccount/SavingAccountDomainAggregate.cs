using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DomainExceptions;
using Domain.DomainExceptions.SavingAccountExceptions;
using System.Net.Http.Headers;

namespace Domain.Entities
{
    public class SavingAccountDomainAggregate
    {
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountForInterests { get; set; }
        public string BeneficiaryNames { get; set; }
        public string BeneficiaryLastNames { get; set; }
        public string BeneficiaryPhoneNumber { get; set; }
        public string BeneficiaryRelationship { get; set; }
        public string BeneficiaryAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CreatedBy { get; set; }
        public List<SavingAccountDepositDomain> Deposits { get; set; }
        public List<SavingAccountWithdrawsDomain> Withdrawals { get; set; }
        public CompanyDomain Company { get; set; }
        public SavingAccountDomainAggregate(int savingAccountID, decimal amount, decimal amountForInterests, 
            bool isActive, int clientID, DateTime createdDate)
        {
            SavingAccountID = savingAccountID;
            Amount = amount;
            AmountForInterests = amountForInterests;
            IsActive = isActive;
            Deposits = new List<SavingAccountDepositDomain>();
            Withdrawals = new List<SavingAccountWithdrawsDomain>();
            ClientID = clientID;
            CreatedDate = createdDate;
        }

        public SavingAccountDomainAggregate()
        {
            Deposits = new List<SavingAccountDepositDomain>();
            Withdrawals = new List<SavingAccountWithdrawsDomain>();
            Company = new CompanyDomain();
        }
        
        public void RollbackPreviousInterestWithdrawal(int saWithdrawalID)
        {
            var withdrawalToRollback = Withdrawals.FirstOrDefault(w => w.SavingAccountWithdrawalID == saWithdrawalID) 
                ?? throw new Exception("No se encontró retiro de intereses.");

            CheckIfWithdrawalIsLatest(withdrawalToRollback.SavingAccountWithdrawalID);
            

        }

        private void CheckIfWithdrawalIsLatest(int withdrawalToRollBackID)
        {
            var latestWithdrawalDate = Withdrawals.OrderByDescending(w => w.CreatedDate).First().SavingAccountWithdrawalID;

            bool isItLatest = latestWithdrawalDate == withdrawalToRollBackID;

            if (isItLatest == false)
                throw new Exception("Unicamente puede eliminar el retiro de intereses mas reciente.");
        }

        public void WithdrawInterests(DateTime withdrawDate, int subPeriodID)
        {
            if (this.IsActive == false)
                throw new InactiveSavingAccountException();

            if (this.AmountForInterests <= 0)
                throw new NoInterestsToWithdrawException();

            if (withdrawDate.Month != 6 )
            {
                if (withdrawDate.Month != 12)
                    throw new InvalidMonthToWithdrawInterestsException();
            }

            Company.DecreaseCurrentAmount(this.AmountForInterests);

            Withdrawals.Add(new SavingAccountWithdrawsDomain
            {
                Amount = this.AmountForInterests,
                SavingAccountID = this.SavingAccountID,
                CreatedDate = withdrawDate,
                SubPeriodID = subPeriodID,
                WithDrawalType = 0 //Interests
            });
     
            this.Amount -= AmountForInterests;
            this.AmountForInterests = 0;      
        }

        public void AddDeposit(decimal depositAmount, DateTime depositDate, 
            int subPeriodID, decimal interestsAmount) 
        {
            if (IsActive == false)
                throw new InactiveSavingAccountException();

            Amount += depositAmount;

            Deposits.Add(new SavingAccountDepositDomain
            {
                Amount = depositAmount,
                SavingAccountID = this.SavingAccountID,
                CreatedDate = depositDate,
                SubPeriodID = subPeriodID,
                SavingAccountDepositID = 0,
                DepositType = 0 //Saving
            });

            Company.AddCurrentAmount(depositAmount);
        }

        public decimal AddInterestIfMonthJuneOrDecember(SubPeriodDomain subPeriod, DateTime depositDate) 
        {
            decimal interestsAmount = 0;
            DateTime startDate = subPeriod.StartDate.AddMonths(-5).Date;
            DateTime endDate = subPeriod.EndDate;

            if (depositDate.Month == 6 || depositDate.Month == 12)
            {
                decimal totalDepositAmountForLastSixMonths = Deposits
                    .Where(d => d.CreatedDate >= startDate && d.CreatedDate <= endDate && d.DepositType == 0)
                    .Sum(d => d.Amount);

                interestsAmount = totalDepositAmountForLastSixMonths * subPeriod.SavingAccInterestRate;

                Amount += interestsAmount;
                AmountForInterests += interestsAmount;

                Deposits.Add(new SavingAccountDepositDomain
                {
                    Amount = interestsAmount,
                    SavingAccountID = this.SavingAccountID,
                    CreatedDate = depositDate,
                    SubPeriodID = subPeriod.SubPeriodID,
                    SavingAccountDepositID = 0,
                    DepositType = 1 //Interests
                });
            }

            return interestsAmount;
        }

        public void FullWithdrawal(DateTime date, int subPeriodID)
        {
            CheckIfFullWithdrawalIsValid(date);
            
            Withdrawals.Add(new SavingAccountWithdrawsDomain
            {
                Amount = this.Amount,
                SavingAccountID = this.SavingAccountID,
                CreatedDate = date,
                SubPeriodID = subPeriodID,
                WithDrawalType = 1 //FullWithdrawal
            });
            
            Company.DecreaseCurrentAmount(this.Amount);

            this.Amount = 0;
            this.AmountForInterests = 0;
            this.IsActive = false;
        }

        private void CheckIfFullWithdrawalIsValid(DateTime date)
        {
            if (IsActive == false)
                throw new InactiveSavingAccountException();

            if (Amount <= 0)
                throw new FundlessSavingAccountException();

            bool isDateLastest = CheckIfDateIsLatest(date);

            if (isDateLastest == false)
                throw new DateIsNotTheLatestSavingAccountException();
        }

        private bool CheckIfDateIsLatest(DateTime date)
        {
            bool isDateLatest = false;
            var latestWithdrawal = Withdrawals.OrderByDescending(a => a.CreatedDate).FirstOrDefault();
            var latestDeposit = Deposits.OrderByDescending(a => a.CreatedDate).FirstOrDefault();

            DateTime latestWithdrawalDate = latestWithdrawal != null ? latestWithdrawal.CreatedDate : DateTime.MinValue;
            DateTime latestDepositDate = latestDeposit != null ? latestDeposit.CreatedDate : DateTime.MinValue;

            var latestTransactionalDate = latestDepositDate;

            if (latestWithdrawalDate > latestDepositDate)
                latestTransactionalDate = latestWithdrawalDate;

            if (date > latestTransactionalDate)
                isDateLatest = true;

            return isDateLatest;
        }
    }

    public class SavingAccountDepositDomain
    { 
        public int SavingAccountID { get; set; }
        public int SavingAccountDepositID { get; set; }
        public int SubPeriodID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DepositType { get; set; }
    }

    public class SavingAccountWithdrawsDomain
    { 
        public int SavingAccountWithdrawalID { get; set; }
        public int SavingAccountID { get; set; }
        public int SubPeriodID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int WithDrawalType { get; set; } //Interests 0, Close account 1
    }
}
