using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CompanyDomain
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public decimal FloatingAmount { get; set; }
        public decimal CurrentAmount { get; set; }

        public void AddFloatingAmount(decimal amount)
        {
            FloatingAmount += amount;
        }

        public void DecreaseCurrentAmount(decimal amount)
        {
            if (CurrentAmount < amount) 
                throw new InvalidOperationException("No existen fondos suficientes");

            CurrentAmount -= amount;
        }
    }
}
