using Domain.Entities;
using Service.Core;
using Service.Core.Dtos;
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

        public Result<bool> CreatePeriods(PeriodToCreateDto periodToCreateDto) 
        {
            var periodExists = CheckIfPeriodExists(periodToCreateDto.Year);

            if (periodExists.IsSucess == false)
                return periodExists;

            _moneySaverRepo.CreatePeriod(periodToCreateDto);

            return Result<bool>.Created(true, "El período ha sido creado exitosamente.");
        }

        public Result<bool> CheckIfPeriodExists(int year) 
        {
            Result<bool> isPeriodValid;
            bool doPeriodExists = _moneySaverRepo.DoPeriodForTheYearExists(year);

            if (year <= 1980)
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

        public PeriodToCreateDto GeneratePeriodToCreateDto(int year) 
        {
            PeriodToCreateDto periodToCreateDto = new PeriodToCreateDto();
            
            var periodDomain = new PeriodDomain(year);
            periodDomain.SetSubPeriods();

            periodToCreateDto.StartDate = periodDomain.StartDate;
            periodToCreateDto.EndDate = periodDomain.EndDate;
            periodToCreateDto.Year = periodDomain.Year;

            periodToCreateDto.SubPeriods = periodDomain.SubPeriods.Select(p => 
            new SubPeriodsToCreateDto 
            {
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                Month = p.Month,
            }).ToList();

            return periodToCreateDto;
        }
    }
}
