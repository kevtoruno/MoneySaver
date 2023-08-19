using System.ComponentModel.DataAnnotations;

namespace Service.Core.DataModel
{
    public class ClientsDataModel
    {
        [Key]
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
        public CompaniesDataModel Company { get; set; }
        public string FirstName { get; set; }
        public string LastNames { get; set; }
        public string Address { get; set; }
        public string WorkArea { get; set; }
        public decimal BaseIncome { get; set; }
        public string INSS { get; set; }
        public string Identification { get; set; }
        public int CreatedBy { get; set; }

        public string GetClientFullName()
        {
            string fullName = LastNames + " " + FirstName ;

            return fullName;
        }
    }
}