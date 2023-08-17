using Service.Core;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.SavingAccounts;

internal class SavingAccountReActivate
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public SavingAccountReActivate(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Result<bool> ReActivate(int savingAccountID)
    {
        var savingAccount = _moneySaverRepo.GetSavingAccountDomain(savingAccountID);

        savingAccount.IsActive = true;

        var result = _moneySaverRepo.UpdateSavingAccount(savingAccount);

        if (result)
            return Result<bool>.Created(true, "Fondo de ahorro activado correctamente");

        return Result<bool>.Failure("Hubo un error.");
    }
}
