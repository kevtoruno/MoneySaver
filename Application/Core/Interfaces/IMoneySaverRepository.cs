using Service.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Interfaces
{
    public interface IMoneySaverRepository
    {
        bool DoINSSExists(string INSS);

        bool DoIdentificationExists(string identification);

        void CreateClient (ClientToCreateDto clientToCreateDto);

        List<ClientToListDto> GetClientsList(string firstName, string LastName);

        bool DoPeriodForTheYearExists(int year);

        void CreatePeriod(PeriodToCreateDto periodToCreateDto);
        List<PeriodsToListDto> GetPeriodsList();

        bool CheckIfClientHasActiveSavingAccount(int clientID);

        void CreateSavingAccount(SavingAccountToCreate savingAccountToCreate);

        List<SavingAccountToListDto> GetSavingAccountsList();
    }
}
