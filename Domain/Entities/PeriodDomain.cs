﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PeriodDomain
    {
        public int Year { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<SubPeriodDomain> SubPeriods { get; private set; }

        public PeriodDomain(int year)
        {
            this.SubPeriods = new List<SubPeriodDomain>();
            this.Year = year;   

            int lastDayOfDecember = DateTime.DaysInMonth(this.Year, 12);

            var startDate = new DateTime(this.Year, 1, 1);
            var endDate = new DateTime(this.Year, 12, lastDayOfDecember);

            EndDate = endDate;
            StartDate = startDate;
        }

        public void SetSubPeriods() 
        {
            for (int month = 1; month <= 12; month++)
            {
                var startDate = new DateTime(Year, month, 1);
                int lastDayOfTheMonth = DateTime.DaysInMonth(Year, month);

                var endDate = new DateTime(Year, month, lastDayOfTheMonth);

                var subPeriodToCreate = new SubPeriodDomain
                {
                    Month = month,
                    StartDate = startDate,
                    EndDate = endDate
                };

                SubPeriods.Add(subPeriodToCreate);
            }
        }
    }

    public class SubPeriodDomain 
    {
        public int SubPeriodID { get; set; }
        public int Month { get; set; }
        public int PeriodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SavingAccInterestRate { get; set; }
        public bool SavingAccInterestProcessed { get; set; }
        public string SubPeriodName
        {
            get
            {    
                return  $"{StartDate.ToString("MMMM")} - {StartDate.Year}";
            }
        }
    }
}
