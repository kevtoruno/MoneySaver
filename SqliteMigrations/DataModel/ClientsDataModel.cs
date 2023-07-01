using System.ComponentModel.DataAnnotations;

namespace Data.DataModel
{
    public class ClientsDataModel
    {
        [Key]
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
        public CompaniesDataModel Company { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastNames { get; set; }
        public int Age { get; set; }
        public string INSS { get; set; }
        public string Identification { get; set; }
        public int CreatedBy { get; set; }
    }
}