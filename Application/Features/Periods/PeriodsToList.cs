using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
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
            var periodsToListDto = _moneySaverRepo.GetPeriodsList().OrderByDescending(a => a.Year).ToList();

            return periodsToListDto;
        }

        public List<SubPeriodsToListDto> GetSubPeriodsList(int periodID) 
        {
            var subPeriodsToListDto = _moneySaverRepo.GetSubPeriodsList(periodID);

            SetSubPeriodName(subPeriodsToListDto);

            return subPeriodsToListDto;   
        }

        private void SetSubPeriodName(List<SubPeriodsToListDto> subPeriodsToListDto)
        {
            subPeriodsToListDto.ForEach(subPeriod => 
            {
                DateTime dummyDate = new DateTime(1996, subPeriod.Month, 18);
                 
                subPeriod.SubPeriodName = dummyDate.ToString("MMMM");
            });
        }
    }
}
