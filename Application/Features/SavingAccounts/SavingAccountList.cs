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
    }
}
