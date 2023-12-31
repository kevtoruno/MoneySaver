﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.DataModel
{
    public class SavingAccountsDataModel
    {
        [Key]
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public ClientsDataModel Client { get; set; }

        public string BeneficiaryNames { get; set; }
        public string BeneficiaryLastNames { get; set; }
        public string BeneficiaryPhoneNumber { get; set; }
        public string BeneficiaryRelationship { get; set; }
        public string BeneficiaryAddress { get; set; }

        [Column(TypeName="money")]
        public decimal Amount { get; set; }

        [Column(TypeName="money")]
        public decimal AmountForInterests { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<SavingAccountDepositsDataModel> Deposits { get; set; }
        public ICollection<SavingAccountWidthdrawalsDataModel> Withdrawals { get; set; }

    }
}
