﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Core.Dtos
{
    public class SavingAccountToCreate
    {
        public int SavingAccountID { get; set; }
        public int ClientID { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountForInterests { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
