using Service.Core;
using Service.Core.DataModel;
using Service.Core.Dtos;
using Service.Core.Dtos.ClientsDto;
using Service.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Features.Client
{
    internal class ClientsCurrentSummaryReport
    {
        private readonly IMoneySaverRepository _moneySaverRepo;
        private readonly ILoansRepository _loansRepo;
        private List<ClientToListDto> ClientsData = new List<ClientToListDto>();
        private List<SavingAccountsDataModel> SavingAccountsData = new List<SavingAccountsDataModel>();
        private List<LoansDataModel> LoansCurrentData = new List<LoansDataModel>();
        private ClientsSummaryReportDto ClientsSummaryReports;
        public ClientsCurrentSummaryReport(IMoneySaverRepository moneySaverRepo, ILoansRepository loansRepo)
        {
            _moneySaverRepo = moneySaverRepo;
            _loansRepo = loansRepo;
            ClientsSummaryReports = new ClientsSummaryReportDto();
        }

        public Result<ClientsSummaryReportDto> GenerateReportDto()
        {
            SavingAccountsData = _moneySaverRepo.GetSavingAccountsList("")
                .Where(sa => sa.IsActive == true)
                .ToList();

            ClientsData = _moneySaverRepo.GetClientsList("");

            LoansCurrentData = _loansRepo.GetActiveLoansList();

            CreateClientsSummaryReports();

            return Result<ClientsSummaryReportDto>.Success(ClientsSummaryReports);
        }

        private void CreateClientsSummaryReports()
        {
            int count = 1;

            foreach (var clientData in ClientsData)
            {
                var clientSummary = new ClientsSummaryData
                {
                    No = count,
                    INSSNo = clientData.INSS,
                    ClientFullName = clientData.FullName
                };

                SetSavingAccountData(clientSummary, clientData.ClientID);
                SetLoanAmount(clientSummary, clientData.ClientID);

                if (clientSummary.SavingsAmountNumber > 0 || clientSummary.CurrentLoanAmountNumber > 0)
                    ClientsSummaryReports.ClientsSummaries.Add(clientSummary);

                count++;
            }
        }

        private void SetSavingAccountData(ClientsSummaryData clientSummary, int clientID)
        {
            var savingAccountData = SavingAccountsData
                    .FirstOrDefault(sa => sa.ClientID == clientID);

            decimal saAmount = 0;
            decimal amountForInterests = 0;
            decimal savingsAmount = 0;

            if (savingAccountData != null)
            {
                saAmount = savingAccountData.Amount;
                amountForInterests = savingAccountData.AmountForInterests;
                savingsAmount = saAmount - amountForInterests;
            }

            clientSummary.SavingsAmount = savingsAmount.MoneyFormat();
            clientSummary.InterestsAmount = amountForInterests.MoneyFormat();
            clientSummary.TotalSavings = saAmount.MoneyFormat();
            clientSummary.SavingsAmountNumber = savingsAmount;
        }

        private void SetLoanAmount(ClientsSummaryData clientSummary, int clientID)
        {
            var clientsLoanData = LoansCurrentData
                .FirstOrDefault(l => l.ClientID == clientID);

            if (clientsLoanData != null)
            {
                clientSummary.CurrentLoanAmount = clientsLoanData.DueAmount.MoneyFormat();
                clientSummary.CurrentLoanAmountNumber = clientsLoanData.DueAmount;
            }
            else
            {
                clientSummary.CurrentLoanAmount = Convert.ToDecimal(0).MoneyFormat();
                clientSummary.CurrentLoanAmountNumber = Convert.ToDecimal(0);
            }
        }
    }
}
