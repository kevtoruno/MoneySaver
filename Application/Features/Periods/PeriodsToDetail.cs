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
    internal class PeriodsToDetail
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepo;
        private readonly PeriodsToDetailDto PeriodsToDetailDto;
        public PeriodsToDetail(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo)
        {
            _moneySaverRepo = moneySaverRepo;
            _loansRepo = loansRepo;
            PeriodsToDetailDto = new PeriodsToDetailDto();
        }

        public Result<PeriodsToDetailDto> GetPeriodToDetail(int periodID)
        {
            try
            {
                var period = _moneySaverRepo.GetPeriodWithSubPeriods(periodID);

                var subPeriodsIDs = period.SubPeriods.Select(x => x.SubPeriodID).ToList();

                PeriodsToDetailDto.PeriodName = $"Período {period.Year}";
                PeriodsToDetailDto.StartDate = period.StartDate.ToShortDateString();
                PeriodsToDetailDto.EndDate = period.EndDate.ToShortDateString();

                var subPeriodsTotalIncome = _moneySaverRepo.GetSubPeriodsTotalIncome(subPeriodsIDs);
                var subPeriodsWithdrawalOutcome = _moneySaverRepo.GetSubPeriodsWithdrawalsOutcome(subPeriodsIDs);
                var loansForPeriod = _loansRepo.GetLoansByDates(period.StartDate, period.EndDate);

                SetSubPeriodsDto(period);
                SetTotalIncome(subPeriodsTotalIncome);
                SetTotalOutcome(subPeriodsWithdrawalOutcome, loansForPeriod);

                return Result<PeriodsToDetailDto>.Success(PeriodsToDetailDto);
            }
            catch (Exception ex)
            {
                return Result<PeriodsToDetailDto>.Failure(ex.Message);
            }
        }

        private void SetSubPeriodsDto(PeriodsDataModel periods)
        {
            periods.SubPeriods.ToList().ForEach(sp =>
            {
                DateTime dummyDate = new DateTime(1996, sp.Month, 18);

                PeriodsToDetailDto.SubPeriods.Add(new SubPeriodsDetailToListDto
                {
                    EndDate = sp.EndDate,
                    StartDate = sp.StartDate,
                    Month = sp.Month,
                    PeriodID = sp.PeriodID,
                    SubPeriodID = sp.SubPeriodID,
                    SubPeriodName = dummyDate.ToString("MMMM")
                });
            });
        }

        private void SetTotalIncome(Dictionary<int, decimal> totalIncomeData)
        {
            foreach (var subPeriod in PeriodsToDetailDto.SubPeriods)
            {
                if (totalIncomeData.ContainsKey(subPeriod.SubPeriodID))
                {
                    subPeriod.TotalIncome = totalIncomeData[subPeriod.SubPeriodID];
                }
            }
        }

        private void SetTotalOutcome(Dictionary<int, decimal> withdrawalOutcomeData,
            List<LoansDataModel> loans)
        {
            foreach (var subPeriod in PeriodsToDetailDto.SubPeriods)
            {
                if (withdrawalOutcomeData.ContainsKey(subPeriod.SubPeriodID))
                {
                    subPeriod.TotalOutcome += withdrawalOutcomeData[subPeriod.SubPeriodID];
                }

                decimal totalLoansAmountForSubPeriod = loans
                    .Where(l => l.StartDate >= subPeriod.StartDate && l.StartDate <= subPeriod.EndDate)
                    .Sum(l => l.LoanAmount);

                subPeriod.TotalOutcome += totalLoansAmountForSubPeriod;
            }
        }
    }
}
