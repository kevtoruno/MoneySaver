using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class ClientToCreateDto
    {
        public int ClientID { get; set; }
        public int CompanyID { get; set; }
        public string FirstName { get; set; }
        public string LastNames { get; set; }
        public string Address { get; set; }
        public string WorkArea { get; set; }
        public decimal BaseIncome { get; set; }
        public string INSS { get; set; }
        public string Identification { get; set; }
        public int CreatedBy { get; set; }
        
    }
}
