using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.PeriodsDto
{
    public class SubPeriodInterestsCalculationDto
    {
        public int PeriodID { get; set; }
        public int PeriodYear { get; set; }
        public int SubPeriodID { get; set; }
        public string SubPeriodName { get; set; }
        public bool SavingAccInterestProcessed { get; set; }
        public decimal SavingAccInterestRate { get; set; }
        public decimal SavingAccInterestRateDisplay { get => SavingAccInterestRate * 100; }
        public decimal TotalAmountLoaned { get; set; }
        public decimal TotalAmountRecovered { get; set; }
        public decimal TotalDepositAmount { get; set; }
        public List<InterestAmountCalculatedForSADto> InterestAmountCalculatedForSavingAccounts { get; set; }
        public SubPeriodInterestsCalculationDto()
        {
            InterestAmountCalculatedForSavingAccounts = new List<InterestAmountCalculatedForSADto>();
        }
    }
}
