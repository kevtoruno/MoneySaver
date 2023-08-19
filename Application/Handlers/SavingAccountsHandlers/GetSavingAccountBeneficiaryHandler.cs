using MediatR;
using Service.Core;
using Service.Core.Dtos;
using Service.Core.Dtos.SavingAccountsDto;
using Service.Core.Interfaces;
using Service.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Handlers;

public class GetSavingAccountBeneficiaryQuery : IRequest<Result<BeneficiaryToEditDto>>
{
    public int SavingAccountID { get; set; }
}

internal class GetSavingAccountBeneficiaryHandler : IRequestHandler<GetSavingAccountBeneficiaryQuery, Result<BeneficiaryToEditDto>>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetSavingAccountBeneficiaryHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<Result<BeneficiaryToEditDto>> Handle(GetSavingAccountBeneficiaryQuery request, CancellationToken cancellationToken)
    {
        var savingAccountBeneficiaryService = new SavingAccountBeneficiary(_moneySaverRepo);

        var result = savingAccountBeneficiaryService.GetBenenficiaryDetail(request.SavingAccountID);

        return Task.FromResult(result);
    }
}
