using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class SADepositToCreateDto
    {
        public int SavingAccountID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal InterestsAmount { get; set; }
    }
}
