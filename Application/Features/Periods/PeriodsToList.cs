using Service.Core.Dtos;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Periods
{
    public class PeriodsToList
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public PeriodsToList(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }

        public List<PeriodsToListDto> GetPeriodsList() 
        {
            var clientToListDto = _moneySaverRepo.GetPeriodsList();

            return clientToListDto;
        }
    }
}
