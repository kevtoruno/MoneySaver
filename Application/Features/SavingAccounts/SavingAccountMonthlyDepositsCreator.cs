using Service.Core.Interfaces;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core;
using Domain.Entities;
using AutoMapper;

namespace Service.Features.SavingAccounts
{
    public class SavingAccountMonthlyDepositsCreator
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly IMapper _mapper;
        private int SubPeriodID = 0;
        private string CreatedMessage = "Se han procesado todas las cotizaciones exitosamente";
        public SavingAccountMonthlyDepositsCreator(IMoneySaverRepository moneySaverRepo, IMapper mapper)
        {
            _moneySaverRepo = moneySaverRepo;
            _mapper = mapper;
        }

        public Result<bool> CreateMonthlyDeposits(string path, DateTime date)
        { 
            var monthlyDepositsPreviewGenerator = new SAMonthlyDepositsPreviewGenerator(_moneySaverRepo);
            var monthlyDepositsForPreviewDto = monthlyDepositsPreviewGenerator.GenerateMonthlyDepositsForPreview(path, date);

            if (monthlyDepositsForPreviewDto.IsSucess == false)
                return Result<bool>.Failure(monthlyDepositsForPreviewDto.ErrorMessage);

            var depositsForPreview = monthlyDepositsForPreviewDto.Value;

            SubPeriodID = monthlyDepositsPreviewGenerator.SubPeriodID;

            if (monthlyDepositsPreviewGenerator.PeriodID <= 0)
                return Result<bool>.Failure("Debe seleccionar un período");

            var savingAccountIDs = depositsForPreview.Where(a => a.IsValid).Select(a => a.SavingAccountID).ToList();

            if (savingAccountIDs.Count == 0)
                return Result<bool>.Failure("No se procesó ningún registro.");

            var validSavingAccountsData = monthlyDepositsPreviewGenerator.SavingAccountsWithDepositsData
                .Where(sa => savingAccountIDs.Contains(sa.SavingAccountID))
                .ToList();

            var savingAccountsDomain = _mapper.Map<List<SavingAccountDomainAggregate>>(validSavingAccountsData);

            if (savingAccountIDs.Count != depositsForPreview.Count)
                CreatedMessage = "Algunas cotizaciones no fueron procesadas.";

            AddDepositToDomain(savingAccountsDomain, depositsForPreview);
            RemoveUnnecesaryDepositsDataFromDomain(savingAccountsDomain);

            _moneySaverRepo.AddDepositsToSavingAccounts(savingAccountsDomain);

            return Result<bool>.Created(true, CreatedMessage);
        }

        private void AddDepositToDomain(List<SavingAccountDomainAggregate> saDomainList, 
            List<MonthlyDepositsForPreviewDto> depositsForPreview)
        {
            saDomainList.ForEach(saD =>
            {
                var depositData = depositsForPreview.FirstOrDefault(data => data.SavingAccountID == saD.SavingAccountID);

                if (depositData != null)
                    saD.AddDeposit(depositData.Amount, depositData.Date, SubPeriodID, 0);
            });
        }

        private void RemoveUnnecesaryDepositsDataFromDomain(List<SavingAccountDomainAggregate> saDomainList)
        {
            saDomainList.ForEach(saD =>
            {
                saD.Deposits.RemoveAll(d => d.SavingAccountDepositID != 0);
            });
        }
    }
}
