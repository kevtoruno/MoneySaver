using MediatR;
using Service.Core;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using Service.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class EditSavingAccountBeneficiaryCommand : IRequest<Result<bool>>
{
    public BeneficiaryToEditDto BeneficiaryToEditDto { get; set; }
}
internal class EditSavingAccountBeneficiaryHandler : IRequestHandler<EditSavingAccountBeneficiaryCommand, Result<bool>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public EditSavingAccountBeneficiaryHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<bool>> Handle(EditSavingAccountBeneficiaryCommand request, CancellationToken cancellationToken)
    {
        var savingAccountBeneficiaryService = new SavingAccountBeneficiary(_moneySaverRepo);

        var result = savingAccountBeneficiaryService.EditSavingAccountBeneficiary(request.BeneficiaryToEditDto);

        return Task.FromResult(result);
    }
}
