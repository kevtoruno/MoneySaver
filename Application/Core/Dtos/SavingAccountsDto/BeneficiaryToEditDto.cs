using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos.SavingAccountsDto
{
    public class BeneficiaryToEditDto
    {
        public int SavingAccountID { get; set; }
        public string BeneficiaryNames { get; set; }
        public string BeneficiaryLastNames { get; set; }
        public string BeneficiaryPhoneNumber { get; set; }
        public string BeneficiaryRelationship { get; set; }
        public string BeneficiaryAddress { get; set; }
    }
}
