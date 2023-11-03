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
    internal class SubPeriodMonthlyInterestAmountCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepo;
        private readonly IMapper _mapper;
        private List<SavingAccountDomainAggregate> SavingAccounts;
        private SubPeriodDomain subPeriodDomain;
        public SubPeriodMonthlyInterestAmountCreator(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo
            , IMapper mapper)
        {
            _moneySaverRepo = moneySaverRepo;
            _loansRepo = loansRepo;
            _mapper = mapper;
        }

        public Result<bool> CreateMonthlyInterestsAmount(int subPeriodID, DateTime depositDate ,int utilityMonths)
        {
            try
            {
                var intAmountCalculator = new SubPeriodInterestAmountCalculator(_moneySaverRepo, _loansRepo, _mapper);

                var previewResult = intAmountCalculator.PreviewInterestAmountsForSavingAccounts(subPeriodID, utilityMonths, depositDate);

                if (previewResult.IsSucess == false)
                    return Result<bool>.Failure(previewResult.ErrorMessage);

                subPeriodDomain = intAmountCalculator.SubPeriod;
                SavingAccounts = intAmountCalculator.SavingAccounts;

                subPeriodDomain.SavingAccInterestProcessed = true;
                _moneySaverRepo.AddDepositsToSavingAccounts(SavingAccounts, company: null);

                return Result<bool>.Created(true, "Se han procesados los intereses correctamente");
            }
            catch (Exception ex)
            {
                Helper.SendErrorToText(ex);
                return Result<bool>.Failure(ex.Message);
            }
        }
    }
}
