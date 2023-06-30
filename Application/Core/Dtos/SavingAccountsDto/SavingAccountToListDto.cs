using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class SavingAccountToListDto
    {
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public string INSS { get; set; }
        public string ClientFullName { get; set; } = "";
        public string Amount { get; set; }
        public string AmountForInterests { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
    }
}
