using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.ClientsDto
{
    public class ClientsSummaryReportDto
    {
        public string SummaryTitle { get; set; }
        public List<ClientsSummaryData> ClientsSummaries { get; set; }
        public ClientsSummaryReportDto()
        {
            ClientsSummaries = new List<ClientsSummaryData>();
        }
    }

    public class ClientsSummaryData
    {
        public int No { get; set; }
        public string INSSNo { get; set; }
        public string ClientFullName { get; set; }
        public string SavingsAmount { get; set; }
        public string InterestsAmount { get; set; }
        public string TotalSavings { get; set; }
        public string CurrentLoanAmount { get; set; }
    }
}
