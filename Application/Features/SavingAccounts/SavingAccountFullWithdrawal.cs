using Service.Core;
using Service.Core.Interfaces;

namespace Service.Features.SavingAccounts;

internal class SavingAccountFullWithdrawal
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public SavingAccountFullWithdrawal(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Result<bool> FullWithdrawal(int savingAccountID, DateTime date)
    {
        try
        {
            var subPeriod = _moneySaverRepo.GetSubPeriodIDFromDate(date);

            int subPeriodID = subPeriod != null ? subPeriod.SubPeriodID : 0;

            if (subPeriodID == 0)
                return Result<bool>.Failure("No existe un subperiodo para la fecha seleccionada.");

            var SADomain = _moneySaverRepo.GetSavingAccountDomain(savingAccountID, includeTransactionalHistory: true);

            SADomain.FullWithdrawal(date, subPeriodID);

            var dbResult = _moneySaverRepo.FullWithdrawalSavingAccount(SADomain);

            if (dbResult)
                return Result<bool>.Created(true, "Se han retirado todos los fondos correctamente.");

            return Result<bool>.Failure("Hubo un error al realizar el retiro total.");
        }
        catch (Exception ex)
        {
            return Result<bool>.Failure(ex.Message);
        }   
    }
}
