using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Core.DataModel;
using System.Collections;
using Service.Core;

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
            var savingAccountsFromDB = _moneySaverRepo.GetSavingAccountsList(INSS);

            var savingAccountToListDto = new List<SavingAccountToListDto>();

            savingAccountsFromDB.ForEach(sa =>
            {
                string fullName = sa.Client.LastNames + " " + sa.Client.FirstName;

                savingAccountToListDto.Add(new SavingAccountToListDto
                {
                    Amount = sa.Amount.CordobaFormat(),
                    INSS = sa.Client.INSS,
                    AmountForInterests = sa.AmountForInterests.CordobaFormat(),
                    IsActive = sa.IsActive,
                    SavingAccountID = sa.SavingAccountID,
                    ClientID = sa.ClientID,
                    CreatedDate = sa.CreatedDate.ToShortDateString(),
                    ClientFullName = fullName
                });
            });

            return savingAccountToListDto;
        }
    }
}
