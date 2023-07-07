using Domain.Entities;
using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Dtos.PeriodsDto;
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

        List<ClientToListDto> GetClientsList(string INSS);

        bool DoPeriodForTheYearExists(int year);

        void CreatePeriod(PeriodToCreateDto periodToCreateDto);
        List<PeriodsToListDto> GetPeriodsList();
        List<SubPeriodsToListDto> GetSubPeriodsList(int periodID);

        bool CheckIfClientHasActiveSavingAccount(int clientID);
        int GetClientIDByINSSNo(string INSSNo);
        void CreateSavingAccount(SavingAccountToCreate savingAccountToCreate);

        List<SavingAccountToListDto> GetSavingAccountsList(string INSS);
        SavingAccountsDataModel GetSavingAccountDetail(int savingAccountID);
        List<SavingAccountWidthdrawalsDataModel> GetSavingAccountWidthdrawals(int savingAccountID);
        List<SavingAccountDepositsDataModel> GetSavingAccountDeposits(int savingAccountID);
        bool AddDepositToSavingAccount(SavingAccountDomainAggregate saDomain);
        bool CheckIfDepositExistsForSubPeriod(int subPeriodID, int savingAccountID);
        bool CheckIfInterestWithdrawExistsForSubPeriod(int subPeriodID, int savingAccountID);
        SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID);
        bool WithdrawInterestsSavingAccount(SavingAccountDomainAggregate saDomain);
        string GetFullNameByINSS(string INSS);
    }
}
