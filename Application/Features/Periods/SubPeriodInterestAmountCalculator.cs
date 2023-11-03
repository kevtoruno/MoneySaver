using AutoMapper;
using Domain.Entities;
using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos.PeriodsDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Periods
{
    internal class SubPeriodInterestAmountCalculator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;
        private SubPeriodInterestsCalculationDto SubPInterestCalcDto;
        public SubPeriodDomain SubPeriod { get; set; }
        public List<SavingAccountDomainAggregate> SavingAccounts { get; private set; }
        public SubPeriodInterestAmountCalculator(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo
            ,IMapper mapper)
        {
            _moneySaverRepo = moneySaverRepo;
            _loansRepo = loansRepo;
            _mapper = mapper;
            SubPInterestCalcDto = new SubPeriodInterestsCalculationDto();
        }

        public Result<SubPeriodInterestsCalculationDto> PreviewInterestAmountsForSavingAccounts(int subPeriodID, 
            int utilityMonths, DateTime depositDate)
        {
            try
            {
                var spData = _moneySaverRepo.GetSubPeriod(subPeriodID);

                SubPeriod = _mapper.Map<SubPeriodDomain>(spData);

                if (SubPeriod.SavingAccInterestProcessed || SubPeriod.SavingAccInterestRate > 0)
                    return Result<SubPeriodInterestsCalculationDto>.Failure("Ya se han pagado intereses para este subperíodo.");

                bool depositDateWithinSubPeriodRange = CheckIfDateIsWithinSubPeriodRange(depositDate);

                if (depositDateWithinSubPeriodRange == false)
                    return Result<SubPeriodInterestsCalculationDto>.Failure("La fecha seleccionada debe de estar dentro del rango del subperiodo.");

                SetDtoBaseData(spData, utilityMonths);
                SubPInterestCalcDto.InterestAmountCalculatedForSavingAccounts = new List<InterestAmountCalculatedForSADto>();

                CalculateAndSetInterestRate();

                if (SubPeriod.SavingAccInterestRate <= 0)
                    return Result<SubPeriodInterestsCalculationDto>.Failure("El resultado para el factor interes es del 0%, no se puede previsualizar.");

                SetInterestAmountCalculatedForSA(depositDate);
                return Result<SubPeriodInterestsCalculationDto>.Success(SubPInterestCalcDto);
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<SubPeriodInterestsCalculationDto>.Failure(ex.Message);
            }
        }

        private bool CheckIfDateIsWithinSubPeriodRange(DateTime depositDate)
        {
            bool depositDateWithinSubPeriodRange = false;

            if (depositDate.Date >= SubPeriod.StartDate && depositDate.Date <= SubPeriod.EndDate)
                    depositDateWithinSubPeriodRange = true;

            return depositDateWithinSubPeriodRange;
        }

        private void CalculateAndSetInterestRate()
        {
            decimal profitAmount = SubPInterestCalcDto.TotalAmountRecovered - SubPInterestCalcDto.TotalAmountLoaned;
            decimal interestRate = 0.3426M;

            if (profitAmount > 0)
            {
                interestRate = profitAmount / SubPInterestCalcDto.TotalDepositAmount;
            }

            SubPeriod.SavingAccInterestRate = interestRate;
            SubPInterestCalcDto.SavingAccInterestRate = interestRate;
        }

        private void SetInterestAmountCalculatedForSA(DateTime depositDate)
        {
            var savingAccData = _moneySaverRepo.GetSavingAccountsWithDepositsForPeriodData(SubPeriod.PeriodID);

            SavingAccounts = _mapper.Map<List<SavingAccountDomainAggregate>>(savingAccData);

            DateTime startDate = SubPeriod.StartDate.AddMonths(-5).Date;
            DateTime endDate = SubPeriod.EndDate;

            foreach (var savingAcc in SavingAccounts)
            {
                bool interestAlreadyExists = savingAcc.Deposits
                    .Any(d => d.SubPeriodID == SubPeriod.SubPeriodID && d.DepositType == 1);

                if (interestAlreadyExists)
                    continue;

                var clientData = savingAccData.First(a => a.SavingAccountID == savingAcc.SavingAccountID).Client;

                decimal interestsGeneratedAmount = savingAcc.AddInterestIfMonthJuneOrDecember(SubPeriod,depositDate);

                decimal depositAmountForLastSixMonths = savingAcc.Deposits
                    .Where(d => d.CreatedDate >= startDate && d.CreatedDate <= endDate && d.DepositType == 0)
                    .Sum(d => d.Amount);

                var interestAmountCalculatedForSA = new InterestAmountCalculatedForSADto
                {
                    ClientFullName = clientData.GetClientFullName(),
                    INSSNo = clientData.INSS,
                    SavingAccountID = savingAcc.SavingAccountID,
                    TotalDepositAmount = depositAmountForLastSixMonths,
                    InterestGeneratedAmount = interestsGeneratedAmount
                };

                SubPInterestCalcDto.InterestAmountCalculatedForSavingAccounts.Add(interestAmountCalculatedForSA);
            }
        }

        public Result<SubPeriodInterestsCalculationDto> GetCurrentInterestFactorForSubPeriod(int subPeriodID)
        {
            try
            {
                var subPeriodDataM = _moneySaverRepo.GetSubPeriod(subPeriodID);

                SetDtoBaseData(subPeriodDataM);

                return Result<SubPeriodInterestsCalculationDto>.Success(SubPInterestCalcDto);
            }
            catch (Exception ex)
            {
                return Result<SubPeriodInterestsCalculationDto>.Failure(ex.Message);
            }
            
        }

        private void SetDtoBaseData(SubPeriodsDataModel subPeriodDataM, int utilityMonths = 6)
        {
            SubPInterestCalcDto.SubPeriodID = subPeriodDataM.SubPeriodID;
            SubPInterestCalcDto.PeriodID = subPeriodDataM.PeriodID;
            SubPInterestCalcDto.PeriodYear = subPeriodDataM.Period.Year;
            SubPInterestCalcDto.SubPeriodName = $"{subPeriodDataM.StartDate.ToString("MMMM")} - {subPeriodDataM.Period.Year}";
            SubPInterestCalcDto.TotalAmountLoaned = _loansRepo.GetTotalAmountLoanedForLastSixMonths(subPeriodDataM, utilityMonths);
            SubPInterestCalcDto.TotalAmountRecovered = _loansRepo.GetTotalAmountRecoveredForLastSixMonths(subPeriodDataM, utilityMonths);
            SubPInterestCalcDto.SavingAccInterestProcessed =    subPeriodDataM.SavingAccInterestProcessed;
            SubPInterestCalcDto.SavingAccInterestRate = subPeriodDataM.SavingAccInterestRate;
            SubPInterestCalcDto.TotalDepositAmount = _moneySaverRepo.GetTotalDepositAmountForTheLastSixMonths(subPeriodDataM);
        }
    }
}
