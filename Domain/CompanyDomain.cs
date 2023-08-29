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

        public void AddCurrentAmount(decimal amount)
        {
            CurrentAmount += amount;
        }

        public void DecreaseCurrentAmount(decimal amount)
        {
            if (CurrentAmount < amount) 
                throw new InvalidOperationException("No existen fondos suficientes");

            CurrentAmount -= amount;
        }

        public void DecreaseFloatingAmount(decimal amount)
        {
            if (FloatingAmount < amount) 
                throw new InvalidOperationException("No existe dicha cantidad flotando");

            FloatingAmount -= amount;
        }
    }
}
