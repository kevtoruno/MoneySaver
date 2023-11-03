using Domain;
using Domain.Entities;
using Domain.Entities.SavingAccount;
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
        bool DoINSSExists(string INSS, int clientIDIgnore = 0);

        bool DoIdentificationExists(string identification, int clientIDIgnore = 0);

        void CreateClient (ClientToCreateDto clientToCreateDto);

        List<ClientToListDto> GetClientsList(string INSS);

        bool DoPeriodForTheYearExists(int year);

        void CreatePeriod(PeriodToCreateDto periodToCreateDto);
        List<PeriodsToListDto> GetPeriodsList();
        List<SubPeriodsToListDto> GetSubPeriodsList(int periodID);

         /// <summary>
        /// 0 means Not existing
        /// 1 means exists and its active
        /// 2 means exists but inactive
        /// </summary>
        int CheckIfClientHasSavingAccount(int clientID);
        int GetClientIDByINSSNo(string INSSNo);
        int CreateSavingAccount(SavingAccountDomainCreator savingAccountToCreate);

        List<SavingAccountsDataModel> GetSavingAccountsList(string INSS);
        SavingAccountsDataModel GetSavingAccountDetail(int savingAccountID);
        List<SavingAccountWidthdrawalsDataModel> GetSavingAccountWidthdrawals(int savingAccountID);
        List<SavingAccountDepositsDataModel> GetSavingAccountDeposits(int savingAccountID);
        bool AddDepositToSavingAccount(SavingAccountDomainAggregate saDomain);
        bool CheckIfDepositExistsForSubPeriod(int subPeriodID, int savingAccountID);
        bool CheckIfInterestWithdrawExistsForSubPeriod(int subPeriodID, int savingAccountID);

        SubPeriodsDataModel GetSubPeriodIDFromDate(DateTime date);

        SavingAccountDomainAggregate GetSavingAccountDomain(int savingAccountID, bool includeTransactionalHistory = false);
        bool WithdrawInterestsSavingAccount(SavingAccountDomainAggregate saDomain);
        string GetFullNameByINSS(string INSS);
        List<SubPeriodDomain> GetSubPeriodsForDateRange(DateTime startDate, DateTime endDate);
        CompanyDomain GetDefaultCompany();
        ClientToCreateDto GetClient(int ClientID);
        List<SavingAccountsDataModel> GetSavingAccountsWithDepositsForPeriodData(int periodID);
        bool AddDepositsToSavingAccounts(List<SavingAccountDomainAggregate> saDomainLst, CompanyDomain company);
        void EditClient(ClientToCreateDto clientToEditDto);
        DateTime GetLatestWithdrawDateForSavingAccountID(int savingAccountID);
        bool FullWithdrawalSavingAccount(SavingAccountDomainAggregate saDomain);

        bool UpdateSavingAccount(SavingAccountDomainAggregate saDomain);
        PeriodsDataModel GetPeriodWithSubPeriods(int periodID);
        Dictionary<int, decimal> GetSubPeriodsTotalIncome(List<int> subPeriodIds);
        Dictionary<int, decimal> GetSubPeriodsWithdrawalsOutcome(List<int> subPeriodIds);
        SubPeriodsDataModel GetSubPeriod(int subPeriodID);
        decimal GetTotalDepositAmountForTheLastSixMonths(SubPeriodsDataModel subPeriod);
        void UpdateSubPeriod(SubPeriodDomain subPeriodDomain);
    }
}
