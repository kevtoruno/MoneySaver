using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.DataModel;

namespace Service.Features.SavingAccounts
{
    public class SavingAccountList
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public SavingAccountList(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public List<SavingAccountToListDto> GetSavingAccountsList(string INSS) 
        {
            var savingAccountToListDto = _moneySaverRepo.GetSavingAccountsList(INSS);

            return savingAccountToListDto;
        }

        public SavingAccountToDetailDto GetSavingAccountDetail(int savingAccountID) 
        {
            var savingAccountData = _moneySaverRepo.GetSavingAccountDetail(savingAccountID);

            var savingAccountDetailDto = new SavingAccountToDetailDto
            {
                Amount = String.Format("{0:#,##0.00}", savingAccountData.Amount),
                IsActive = savingAccountData.IsActive,
                AmountForInterests = String.Format("{0:#,##0.00}", savingAccountData.AmountForInterests),
                SavingAccountID = savingAccountData.SavingAccountID,
                CreatedDate = savingAccountData.CreatedDate.ToShortDateString(),
                ClientFullName = $"{savingAccountData.Client.LastNames} {savingAccountData.Client.FirstName} {savingAccountData.Client.SecondName}",
                INSS = savingAccountData.Client.INSS,
                Identification = savingAccountData.Client.Identification,
            };

            if (savingAccountDetailDto.ClientFullName.Length > 38 ) 
                savingAccountDetailDto.ClientFullName = savingAccountDetailDto.ClientFullName.Substring(0,37) + "...";

            SetSavingAccountDeposits(savingAccountDetailDto);
            SetSavingAccountWidthdrawals(savingAccountDetailDto);

            var totalWithdrawn = savingAccountDetailDto.SavingAccountsHistoryToList
                .Where(sa => sa.HistoryType == SavingAccountHistoryType.FullWithdrawn || 
                sa.HistoryType == SavingAccountHistoryType.InterestsWithdrawn)
                .Sum(a => a.Amount);

            savingAccountDetailDto.TotalWithdrawn = String.Format("{0:#,##0.00}", totalWithdrawn);

            var totalAmount = savingAccountDetailDto.SavingAccountsHistoryToList
                .Where(sa => sa.HistoryType == SavingAccountHistoryType.Deposit || sa.HistoryType == SavingAccountHistoryType.InterestDeposit)
                .Sum(a => a.Amount);

            savingAccountDetailDto.TotalAmount = String.Format("{0:#,##0.00}", totalAmount); 

            SetTotal(savingAccountDetailDto);

            savingAccountDetailDto.SavingAccountsHistoryToList.Reverse();

            return savingAccountDetailDto;
        }

        private void SetSavingAccountDeposits(SavingAccountToDetailDto savingAccountDetailDto) 
        {
            var savingAccountDepositsData = _moneySaverRepo.GetSavingAccountDeposits(savingAccountDetailDto.SavingAccountID);

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
                
                savingAccountDetailDto.SavingAccountsHistoryToList.Add(saHistoryToListDto);
            });
        }

        private void SetSavingAccountWidthdrawals(SavingAccountToDetailDto savingAccountDetailDto) 
        {      
            var savingAccountWithdrawalsData = _moneySaverRepo.GetSavingAccountWidthdrawals(savingAccountDetailDto.SavingAccountID);

            savingAccountWithdrawalsData.ForEach(saw =>
            {
                var subPeriodName = "";

                if (saw.SubPeriod != null) 
                {
                    var date = new DateTime(saw.SubPeriod.Period.Year, saw.SubPeriod.Month, 1);

                    subPeriodName = $"{date.ToString("MMMM")} {saw.SubPeriod.Period.Year}";
                }

                var saHistoryToListDto = new SavingAccountsHistoryToListDto
                {
                    SavingAccountHistoryID = saw.SavingAccountWithdrawalID,
                    CreatedDate = saw.CreatedDate,
                    SubPeriodID = saw.SubPeriodID != null ? saw.SubPeriodID.Value : 0,
                    SubPeriodName = subPeriodName,
                    Amount = saw.Amount,
                };

                if (saw.WithDrawalType == WithDrawalType.Interests)
                {
                    saHistoryToListDto.HistoryType = SavingAccountHistoryType.InterestsWithdrawn;
                    saHistoryToListDto.HistoryName = "Ret. Intereses";
                }
                else
                {
                    saHistoryToListDto.HistoryType = SavingAccountHistoryType.FullWithdrawn;
                    saHistoryToListDto.HistoryName = "Cierre cuenta";
                }

                savingAccountDetailDto.SavingAccountsHistoryToList.Add(saHistoryToListDto);
            });

        }

        private void SetTotal(SavingAccountToDetailDto savingAccountDetailDto)
        {
            savingAccountDetailDto.SavingAccountsHistoryToList = savingAccountDetailDto
                .SavingAccountsHistoryToList.OrderBy(a => a.CreatedDate).ToList();

            int count = 0;
            decimal prevTotalAmount = 0;

            savingAccountDetailDto.SavingAccountsHistoryToList.ForEach(s =>
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
