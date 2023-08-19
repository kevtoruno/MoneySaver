using MediatR;
using Service.Core.Dtos;
using Service.Core.Interfaces;
using Service.Features;

namespace Service.Handlers;

public class GetSavingAccountDetailQuery : IRequest<SavingAccountToDetailDto>
{
    public int SavingAccountID { get; set; }
}

internal class GetSavingAccountDetailHandler : IRequestHandler<GetSavingAccountDetailQuery, SavingAccountToDetailDto>
{
    private readonly IMoneySaverRepository _moneySaverRepo;

    public GetSavingAccountDetailHandler(IMoneySaverRepository moneySaverRepo)
    {
        _moneySaverRepo = moneySaverRepo;
    }

    public Task<SavingAccountToDetailDto> Handle(GetSavingAccountDetailQuery request, CancellationToken cancellationToken)
    {
        var savingAccountToList = new SavingAccountToDetail(_moneySaverRepo);

        var savingAccountToDetailDto = savingAccountToList.GetSavingAccountDetail(request.SavingAccountID);

        return Task.FromResult(savingAccountToDetailDto);
    }
}
