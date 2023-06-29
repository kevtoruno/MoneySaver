using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Periods
{
    public class PeriodsCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;

        public PeriodsCreator(IMoneySaverRepository moneySaverRepo)
        {
            _moneySaverRepo = moneySaverRepo;
        }


        public Result<bool> CheckIfPeriodExists(int year) 
        {
            Result<bool> isPeriodValid;
            bool doPeriodExists = _moneySaverRepo.DoPeriodForTheYearExists(year);

            if (year <= 2000)
            {
                isPeriodValid = Result<bool>.Failure("Año invalido");
            }
            else if (doPeriodExists == true)
            {
                isPeriodValid = Result<bool>.Failure("Un período para este año ya existe.");
            }
            else
                isPeriodValid = Result<bool>.NoAction(true);

            return isPeriodValid;
        }
    }
}
