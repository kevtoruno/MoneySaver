using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            savingAccountDetailDto.WidthdrawalsToList = GetSavingAccountWidthdrawals(savingAccountID);
            savingAccountDetailDto.DepositsToList = GetSavingAccountDeposits(savingAccountID);

            var totalWithdrawn = savingAccountDetailDto.WidthdrawalsToList.Sum(a => a.Amount);
            savingAccountDetailDto.TotalWithdrawn = String.Format("{0:#,##0.00}", totalWithdrawn);

            var totalAmount = savingAccountDetailDto.DepositsToList.Sum(a => a.Amount);
            savingAccountDetailDto.TotalAmount = String.Format("{0:#,##0.00}", totalAmount);

            return savingAccountDetailDto;
        }

        private List<SavingAccountDepositsToListDto> GetSavingAccountDeposits(int savingAccountID) 
        {
            var savingAccountDeposits = new List<SavingAccountDepositsToListDto>();

            var savingAccountDepositsData = _moneySaverRepo.GetSavingAccountDeposits(savingAccountID);

            savingAccountDepositsData.ForEach(sad =>
            {
                var subPeriodName = "";

                if (sad.SubPeriod != null) 
                {
                    var date = new DateTime(sad.SubPeriod.Period.Year, sad.SubPeriod.Month, 1);

                    subPeriodName = $"Período de {date.ToString("MMMM")} del {sad.SubPeriod.Period.Year}";
                }

                savingAccountDeposits.Add(new SavingAccountDepositsToListDto
                {
                    Amount = sad.Amount,
                    SavingAccountDepositID = sad.SavingAccountDepositID,
                    CreatedDate = sad.CreatedDate,
                    SubPeriodID = sad.SubPeriodID,
                    SubPeriodName = subPeriodName
                });
            });

            return savingAccountDeposits;
        }

        private List<SavingAccountWidthdrawalsToListDto> GetSavingAccountWidthdrawals(int savingAccountID) 
        {
            var savingAccountWithdrawals = new List<SavingAccountWidthdrawalsToListDto>();
            
            var savingAccountWithdrawalsData = _moneySaverRepo.GetSavingAccountWidthdrawals(savingAccountID);

            savingAccountWithdrawalsData.ForEach(saw =>
            {
                var subPeriodName = "";

                if (saw.SubPeriod != null) 
                {
                    var date = new DateTime(saw.SubPeriod.Period.Year, saw.SubPeriod.Month, 1);

                    subPeriodName = $"Período de {date.ToString("MMMM")} del {saw.SubPeriod.Period.Year}";
                }

                savingAccountWithdrawals.Add(new SavingAccountWidthdrawalsToListDto
                {
                    Amount = saw.Amount,
                    SavingAccountWithdrawalID = saw.SavingAccountWithdrawalID,
                    CreatedDate = saw.CreatedDate,
                    SubPeriodID = saw.SubPeriodID != null ? saw.SubPeriodID.Value : 0,
                    SubPeriodName = subPeriodName
                });
            });

            return savingAccountWithdrawals;
        }
    }
}
