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

        public Result<bool> CreatePeriods(int year, int companyID) 
        {
            var periodExists = CheckIfPeriodExists(year);

            if (periodExists.IsSucess == false)
                return periodExists;

            var periodToCreateDto = GeneratePeriodToCreateDto(year).Value;

            periodToCreateDto.CompanyID = companyID;

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

        public Result<PeriodToCreateDto> GeneratePeriodToCreateDto(int year) 
        {
            var periodExists = CheckIfPeriodExists(year);

            if (periodExists.IsSucess == false)
                return Result<PeriodToCreateDto>.Failure(periodExists.ErrorMessage);

            var periodToCreateDto = new PeriodToCreateDto();
            
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

            return Result<PeriodToCreateDto>.Success(periodToCreateDto);
        }
    }
}
