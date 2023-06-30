﻿// <auto-generated />
using System;
using SqliteMigrations.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SqliteMigrations.Migrations
{
    [DbContext(typeof(MoneySaverContext))]
    [Migration("20230630034547_sqliteInitialMigration")]
    partial class sqliteInitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("Data.DataModel.ClientsDataModel", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("INSS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastNames")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClientID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Data.DataModel.CompaniesDataModel", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CurrentAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("FloatingAmount")
                        .HasColumnType("money");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Data.DataModel.InterestRangesDataModel", b =>
                {
                    b.Property<int>("InterestRangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("From")
                        .HasColumnType("money");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("To")
                        .HasColumnType("money");

                    b.HasKey("InterestRangeID");

                    b.HasIndex("CompanyID");

                    b.ToTable("InterestRanges");
                });

            modelBuilder.Entity("Data.DataModel.Loan.LoanInstallmentsDataModel", b =>
                {
                    b.Property<int>("LoanInstallmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoanID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubPeriodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoanInstallmentID");

                    b.HasIndex("LoanID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("LoanInstallments");
                });

            modelBuilder.Entity("Data.DataModel.Loan.LoanPaymentHistoryDataModel", b =>
                {
                    b.Property<int>("LoanHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsExtraPayment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoanID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SubPeriodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoanHistoryID");

                    b.HasIndex("LoanID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("LoanPaymentHistory");
                });

            modelBuilder.Entity("Data.DataModel.LoanInterestsDataModel", b =>
                {
                    b.Property<int>("LoanInterestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoanInterestID");

                    b.HasIndex("CompanyID");

                    b.ToTable("LoanInterests");
                });

            modelBuilder.Entity("Data.DataModel.LoansDataModel", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("ClientID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("money");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Interests")
                        .HasColumnType("money");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("money");

                    b.Property<int>("LoanInterestID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TermAmount")
                        .HasColumnType("money");

                    b.Property<int>("TotalTerms")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoanID");

                    b.HasIndex("ClientID");

                    b.HasIndex("LoanInterestID");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Data.DataModel.PeriodsDataModel", b =>
                {
                    b.Property<int>("PeriodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("PeriodID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountDepositsDataModel", b =>
                {
                    b.Property<int>("SavingAccountDepositID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SavingAccountID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubPeriodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SavingAccountDepositID");

                    b.HasIndex("SavingAccountID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("SavingAccountDeposits");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountWidthdrawalsDataModel", b =>
                {
                    b.Property<int>("SavingAccountWithdrawalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SavingAccountID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SubPeriodID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SavingAccountWithdrawalID");

                    b.HasIndex("SavingAccountID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("SavingAccountWidthdrawals");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountsDataModel", b =>
                {
                    b.Property<int>("SavingAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<decimal>("AmountForInterests")
                        .HasColumnType("money");

                    b.Property<int>("ClientID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ClosedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("SavingAccountID");

                    b.HasIndex("ClientID");

                    b.ToTable("SavingAccounts");
                });

            modelBuilder.Entity("Data.DataModel.SubPeriodsDataModel", b =>
                {
                    b.Property<int>("SubPeriodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PeriodID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("SubPeriodID");

                    b.HasIndex("PeriodID");

                    b.ToTable("SubPeriods");
                });

            modelBuilder.Entity("Data.DataModel.ClientsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Data.DataModel.InterestRangesDataModel", b =>
                {
                    b.HasOne("Data.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Data.DataModel.Loan.LoanInstallmentsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.LoansDataModel", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Data.DataModel.Loan.LoanPaymentHistoryDataModel", b =>
                {
                    b.HasOne("Data.DataModel.LoansDataModel", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID");

                    b.Navigation("Loan");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Data.DataModel.LoanInterestsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Data.DataModel.LoansDataModel", b =>
                {
                    b.HasOne("Data.DataModel.ClientsDataModel", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DataModel.LoanInterestsDataModel", "LoanInterest")
                        .WithMany()
                        .HasForeignKey("LoanInterestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("LoanInterest");
                });

            modelBuilder.Entity("Data.DataModel.PeriodsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountDepositsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.SavingAccountsDataModel", "SavingAccount")
                        .WithMany()
                        .HasForeignKey("SavingAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SavingAccount");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountWidthdrawalsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.SavingAccountsDataModel", "SavingAccount")
                        .WithMany()
                        .HasForeignKey("SavingAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID");

                    b.Navigation("SavingAccount");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Data.DataModel.SavingAccountsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.ClientsDataModel", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Data.DataModel.SubPeriodsDataModel", b =>
                {
                    b.HasOne("Data.DataModel.PeriodsDataModel", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Period");
                });
#pragma warning restore 612, 618
        }
    }
}
