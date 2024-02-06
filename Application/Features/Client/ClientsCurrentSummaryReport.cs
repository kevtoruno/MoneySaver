using Service.Core;
using Service.Core.DataModel;
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
        private List<SavingAccountsDataModel> SavingAccountsData;
        private List<LoansDataModel> LoansCurrentData;
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

            LoansCurrentData = _loansRepo.GetActiveLoansList();

            CreateClientsSummaryReports();

            return Result<ClientsSummaryReportDto>.Success(ClientsSummaryReports);
        }

        private void CreateClientsSummaryReports()
        {
            int count = 1;
            foreach (var sa in SavingAccountsData.OrderBy(sa => sa.Client.INSS))
            {
                decimal savingsAmount = sa.Amount - sa.AmountForInterests;

                var clientSummary = new ClientsSummaryData
                {
                    No = count,
                    INSSNo = sa.Client.INSS,
                    ClientFullName = sa.Client.GetClientFullName(),
                    SavingsAmount = savingsAmount.MoneyFormat(),
                    InterestsAmount = sa.AmountForInterests.MoneyFormat(),
                    TotalSavings = sa.Amount.MoneyFormat()
                };

                SetLoanAmount(clientSummary, sa.ClientID);

                ClientsSummaryReports.ClientsSummaries.Add(clientSummary);
                count++;
            }
        }

        private void SetLoanAmount(ClientsSummaryData clientSummary, int clientID)
        {
            var clientsLoanData = LoansCurrentData
                .FirstOrDefault(l => l.ClientID == clientID);

            if (clientsLoanData != null) 
                clientSummary.CurrentLoanAmount = clientsLoanData.DueAmount.MoneyFormat();
            else
                clientSummary.CurrentLoanAmount = Convert.ToDecimal(0).MoneyFormat(); 
        }
    }
}
