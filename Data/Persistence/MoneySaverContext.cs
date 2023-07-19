using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Service.Core.DataModel;

namespace Data.Persistence
{
    public class MoneySaverContext : DbContext
    {
        public MoneySaverContext(DbContextOptions<MoneySaverContext> options) : base(options) { }
        public DbSet<ClientsDataModel> Clients { get; set; }
        public DbSet<CompaniesDataModel> Companies { get; set; }
        public DbSet<InterestRangesDataModel> InterestRanges { get; set; }
        public DbSet<PeriodsDataModel> Periods { get; set; }
        public DbSet<SubPeriodsDataModel> SubPeriods { get; set; } 

        /*Saving accoun*/
        public DbSet<SavingAccountsDataModel> SavingAccounts { get; set; }
        public DbSet<SavingAccountWidthdrawalsDataModel> SavingAccountWidthdrawals { get; set; }
        public DbSet<SavingAccountDepositsDataModel> SavingAccountDeposits { get; set; }

        /*LOANS*/
        public DbSet<LoansDataModel> Loans { get; set; }
        public DbSet<LoanInterestsDataModel> LoanInterests { get; set; }
        public DbSet<LoanInstallmentsDataModel> LoanInstallments { get; set; }
        public DbSet<LoanPaymentHistoryDataModel> LoanPaymentHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientsDataModel>()
                .Property(e => e.ClientID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<LoansDataModel>()
                .HasIndex(l => l.CKCode)
                .IsUnique();
        }

    }
}
