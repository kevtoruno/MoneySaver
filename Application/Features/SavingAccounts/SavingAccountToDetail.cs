using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features
{
    internal class SavingAccountToDetail
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly SavingAccountToDetailDto SavingAccountToDetailDto;

        public SavingAccountToDetail(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
            SavingAccountToDetailDto = new SavingAccountToDetailDto();
        }

        public SavingAccountToDetailDto GetSavingAccountDetail(int savingAccountID) 
        {
            var savingAccountData = _moneySaverRepo.GetSavingAccountDetail(savingAccountID);
            
            SavingAccountToDetailDto.Amount = String.Format("{0:#,##0.00}", savingAccountData.Amount);
            SavingAccountToDetailDto.IsActive = savingAccountData.IsActive;
            SavingAccountToDetailDto.AmountForInterests = String.Format("{0:#,##0.00}", savingAccountData.AmountForInterests);
            SavingAccountToDetailDto.SavingAccountID = savingAccountData.SavingAccountID;
            SavingAccountToDetailDto.CreatedDate = savingAccountData.CreatedDate.ToShortDateString();
            SavingAccountToDetailDto.ClientFullName = $"{savingAccountData.Client.LastNames} {savingAccountData.Client.FirstName}";
            SavingAccountToDetailDto.INSS = savingAccountData.Client.INSS;
            SavingAccountToDetailDto.Identification = savingAccountData.Client.Identification;       

            if (string.IsNullOrEmpty(savingAccountData.BeneficiaryNames) == false)
                SavingAccountToDetailDto.Beneficiary = $"{savingAccountData.BeneficiaryLastNames} {savingAccountData.BeneficiaryNames} ({savingAccountData.BeneficiaryRelationship})";

            if (SavingAccountToDetailDto.ClientFullName.Length > 38 ) 
                SavingAccountToDetailDto.ClientFullName = string.Concat(SavingAccountToDetailDto.ClientFullName.AsSpan(0, 37), "...");

            SetSavingAccountDeposits();
            SetSavingAccountWidthdrawals();
            SetSummaryTotalAmountAndWithdrawn();
            
            SetTotalForHistory();

            SavingAccountToDetailDto.SavingAccountsHistoryToList.Reverse();

            return SavingAccountToDetailDto;
        }     

        private void SetSavingAccountDeposits() 
        {
            var savingAccountDepositsData = _moneySaverRepo.GetSavingAccountDeposits(SavingAccountToDetailDto.SavingAccountID);

            savingAccountDepositsData.ForEach(sad =>
            {
                var subPeriodName = "";

                if (sad.SubPeriod != null) 
                {
                    var date = new DateTime(sad.SubPeriod.Period.Year, sad.SubPeriod.Month, 1);

                    subPeriodName = $"{date.ToString("MMMM")} {sad.SubPeriod.Period.Year}";
                }

                var saHistoryToListDto = new SavingAccountsHistoryToListDto
                {
                    SavingAccountHistoryID = sad.SavingAccountDepositID,
                    CreatedDate = sad.CreatedDate,
                    SubPeriodID = sad.SubPeriodID,
                    SubPeriodName = subPeriodName,
                    Amount = sad.Amount,
                    HistoryType = SavingAccountHistoryType.Deposit,
                    HistoryName = "Ahorro"
                };

                if (sad.DepositType == DepositType.Interests)
                {
                    saHistoryToListDto.HistoryType = SavingAccountHistoryType.InterestDeposit;
                    saHistoryToListDto.HistoryName = "Interes";
                }
                
                SavingAccountToDetailDto.SavingAccountsHistoryToList.Add(saHistoryToListDto);
            });
        }

        private void SetSavingAccountWidthdrawals() 
        {      
            var savingAccountWithdrawalsData = _moneySaverRepo.GetSavingAccountWidthdrawals(SavingAccountToDetailDto.SavingAccountID);

            savingAccountWithdrawalsData.ForEach(saw =>
            {
                var date = new DateTime(saw.SubPeriod.Period.Year, saw.SubPeriod.Month, 1);

                var subPeriodName = $"{date.ToString("MMMM")} {saw.SubPeriod.Period.Year}";

                var saHistoryToListDto = new SavingAccountsHistoryToListDto
                {
                    SavingAccountHistoryID = saw.SavingAccountWithdrawalID,
                    CreatedDate = saw.CreatedDate,
                    SubPeriodID = saw.SubPeriodID != null ? saw.SubPeriodID.Value : 0,
                    SubPeriodName = subPeriodName,
                    Amount = saw.Amount,
                };

                SetSavingAccountWithdrawalType(saHistoryToListDto, saw.WithDrawalType);

                SavingAccountToDetailDto.SavingAccountsHistoryToList.Add(saHistoryToListDto);
            });

        }

        private void SetSavingAccountWithdrawalType(SavingAccountsHistoryToListDto SavingAccountHistoryDto,
            WithDrawalType withDrawalType)
        {
            if (withDrawalType == WithDrawalType.Interests)
            {
                SavingAccountHistoryDto.HistoryType = SavingAccountHistoryType.InterestsWithdrawn;
                SavingAccountHistoryDto.HistoryName = "Ret. Intereses";
            }
            else
            {
                SavingAccountHistoryDto.HistoryType = SavingAccountHistoryType.FullWithdrawn;
                SavingAccountHistoryDto.HistoryName = "Cierre cuenta";
            }
        }

        private void SetSummaryTotalAmountAndWithdrawn()
        {
            var totalWithdrawn = SavingAccountToDetailDto.SavingAccountsHistoryToList
                .Where(sa => sa.HistoryType == SavingAccountHistoryType.FullWithdrawn || 
                sa.HistoryType == SavingAccountHistoryType.InterestsWithdrawn)
                .Sum(a => a.Amount);

            SavingAccountToDetailDto.TotalWithdrawn = String.Format("{0:#,##0.00}", totalWithdrawn);

            var totalAmount = SavingAccountToDetailDto.SavingAccountsHistoryToList
                .Where(sa => sa.HistoryType == SavingAccountHistoryType.Deposit || sa.HistoryType == SavingAccountHistoryType.InterestDeposit)
                .Sum(a => a.Amount);

            SavingAccountToDetailDto.TotalAmount = String.Format("{0:#,##0.00}", totalAmount); 
        }

        private void SetTotalForHistory()
        {
            SavingAccountToDetailDto.SavingAccountsHistoryToList = SavingAccountToDetailDto
                .SavingAccountsHistoryToList.OrderBy(a => a.CreatedDate).ToList();

            int count = 0;
            decimal prevTotalAmount = 0;

            SavingAccountToDetailDto.SavingAccountsHistoryToList.ForEach(s =>
            {
                if (count > 0)
                {
                    if (s.HistoryType == SavingAccountHistoryType.Deposit || s.HistoryType == SavingAccountHistoryType.InterestDeposit)
                        s.Total = s.Amount + prevTotalAmount;
                    else if (s.HistoryType == SavingAccountHistoryType.InterestsWithdrawn)
                        s.Total = prevTotalAmount - s.Amount;
                    else if (s.HistoryType == SavingAccountHistoryType.FullWithdrawn)
                        s.Total = prevTotalAmount - s.Amount;                   
                }
                else
                    s.Total = s.Amount;

                prevTotalAmount = s.Total;

                count++;
            });
        }
    }
}
