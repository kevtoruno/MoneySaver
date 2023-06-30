using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataModel
{
    public class SavingAccountsDataModel
    {
        [Key]
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public ClientsDataModel Client { get; set; }

        [Column(TypeName="money")]
        public decimal Amount { get; set; }

        [Column(TypeName="money")]
        public decimal AmountForInterests { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
