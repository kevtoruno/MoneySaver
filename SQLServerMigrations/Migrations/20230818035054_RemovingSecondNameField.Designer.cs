﻿// <auto-generated />
using System;
using Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SQLServerMigrations.Migrations
{
    [DbContext(typeof(MoneySaverContext))]
    [Migration("20230818035054_RemovingSecondNameField")]
    partial class RemovingSecondNameField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Service.Core.DataModel.ClientsDataModel", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BaseIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Service.Core.DataModel.CompaniesDataModel", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentAmount")
                        .HasColumnType("money");

                    b.Property<decimal>("FloatingAmount")
                        .HasColumnType("money");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Service.Core.DataModel.InterestRangesDataModel", b =>
                {
                    b.Property<int>("InterestRangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestRangeID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<decimal>("From")
                        .HasColumnType("money");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("To")
                        .HasColumnType("money");

                    b.HasKey("InterestRangeID");

                    b.HasIndex("CompanyID");

                    b.ToTable("InterestRanges");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanInstallmentsDataModel", b =>
                {
                    b.Property<int>("LoanInstallmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanInstallmentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("money");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.Property<int>("SubPeriodID")
                        .HasColumnType("int");

                    b.HasKey("LoanInstallmentID");

                    b.HasIndex("LoanID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("LoanInstallments");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanInterestsDataModel", b =>
                {
                    b.Property<int>("LoanInterestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanInterestID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<decimal>("LoanPaperCost")
                        .HasColumnType("money");

                    b.HasKey("LoanInterestID");

                    b.HasIndex("CompanyID");

                    b.ToTable("LoanInterests");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanPaymentHistoryDataModel", b =>
                {
                    b.Property<int>("LoanHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanHistoryID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExtraPayment")
                        .HasColumnType("bit");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.Property<int?>("SubPeriodID")
                        .HasColumnType("int");

                    b.HasKey("LoanHistoryID");

                    b.HasIndex("LoanID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("LoanPaymentHistory");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoansDataModel", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<string>("CKCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("money");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuarantorAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GuarantorBaseIncome")
                        .HasColumnType("money");

                    b.Property<string>("GuarantorFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorINSSNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuarantorWorkArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Interests")
                        .HasColumnType("money");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<decimal>("LoanAmount")
                        .HasColumnType("money");

                    b.Property<int>("LoanInterestID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TermAmount")
                        .HasColumnType("money");

                    b.Property<int>("TotalTerms")
                        .HasColumnType("int");

                    b.HasKey("LoanID");

                    b.HasIndex("CKCode")
                        .IsUnique();

                    b.HasIndex("ClientID");

                    b.HasIndex("LoanInterestID");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Service.Core.DataModel.PeriodsDataModel", b =>
                {
                    b.Property<int>("PeriodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PeriodID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("PeriodID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountDepositsDataModel", b =>
                {
                    b.Property<int>("SavingAccountDepositID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavingAccountDepositID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepositType")
                        .HasColumnType("int");

                    b.Property<int>("SavingAccountID")
                        .HasColumnType("int");

                    b.Property<int>("SubPeriodID")
                        .HasColumnType("int");

                    b.HasKey("SavingAccountDepositID");

                    b.HasIndex("SavingAccountID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("SavingAccountDeposits");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountWidthdrawalsDataModel", b =>
                {
                    b.Property<int>("SavingAccountWithdrawalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavingAccountWithdrawalID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SavingAccountID")
                        .HasColumnType("int");

                    b.Property<int?>("SubPeriodID")
                        .HasColumnType("int");

                    b.Property<int>("WithDrawalType")
                        .HasColumnType("int");

                    b.HasKey("SavingAccountWithdrawalID");

                    b.HasIndex("SavingAccountID");

                    b.HasIndex("SubPeriodID");

                    b.ToTable("SavingAccountWidthdrawals");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountsDataModel", b =>
                {
                    b.Property<int>("SavingAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavingAccountID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<decimal>("AmountForInterests")
                        .HasColumnType("money");

                    b.Property<string>("BeneficiaryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiaryLastNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiaryNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiaryPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiaryRelationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClosedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("SavingAccountID");

                    b.HasIndex("ClientID");

                    b.ToTable("SavingAccounts");
                });

            modelBuilder.Entity("Service.Core.DataModel.SubPeriodsDataModel", b =>
                {
                    b.Property<int>("SubPeriodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubPeriodID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("PeriodID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SubPeriodID");

                    b.HasIndex("PeriodID");

                    b.ToTable("SubPeriods");
                });

            modelBuilder.Entity("Service.Core.DataModel.ClientsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Service.Core.DataModel.InterestRangesDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanInstallmentsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.LoansDataModel", "Loan")
                        .WithMany("LoanInstallments")
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Core.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanInterestsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoanPaymentHistoryDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.LoansDataModel", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Core.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID");

                    b.Navigation("Loan");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoansDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.ClientsDataModel", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Core.DataModel.LoanInterestsDataModel", "LoanInterest")
                        .WithMany()
                        .HasForeignKey("LoanInterestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("LoanInterest");
                });

            modelBuilder.Entity("Service.Core.DataModel.PeriodsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.CompaniesDataModel", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountDepositsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.SavingAccountsDataModel", "SavingAccount")
                        .WithMany("Deposits")
                        .HasForeignKey("SavingAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Core.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SavingAccount");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountWidthdrawalsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.SavingAccountsDataModel", "SavingAccount")
                        .WithMany("Withdrawals")
                        .HasForeignKey("SavingAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Service.Core.DataModel.SubPeriodsDataModel", "SubPeriod")
                        .WithMany()
                        .HasForeignKey("SubPeriodID");

                    b.Navigation("SavingAccount");

                    b.Navigation("SubPeriod");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.ClientsDataModel", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Service.Core.DataModel.SubPeriodsDataModel", b =>
                {
                    b.HasOne("Service.Core.DataModel.PeriodsDataModel", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Period");
                });

            modelBuilder.Entity("Service.Core.DataModel.LoansDataModel", b =>
                {
                    b.Navigation("LoanInstallments");
                });

            modelBuilder.Entity("Service.Core.DataModel.SavingAccountsDataModel", b =>
                {
                    b.Navigation("Deposits");

                    b.Navigation("Withdrawals");
                });
#pragma warning restore 612, 618
        }
    }
}
