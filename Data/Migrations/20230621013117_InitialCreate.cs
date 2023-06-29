using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloatingAmount = table.Column<decimal>(type: "money", nullable: false),
                    CurrentAmount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    INSS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InterestRanges",
                columns: table => new
                {
                    InterestRangeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<decimal>(type: "money", nullable: false),
                    To = table.Column<decimal>(type: "money", nullable: false),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestRanges", x => x.InterestRangeID);
                    table.ForeignKey(
                        name: "FK_InterestRanges_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LoanInterests",
                columns: table => new
                {
                    LoanInterestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    InterestRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanInterests", x => x.LoanInterestID);
                    table.ForeignKey(
                        name: "FK_LoanInterests_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    PeriodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.PeriodID);
                    table.ForeignKey(
                        name: "FK_Periods_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SavingAccounts",
                columns: table => new
                {
                    SavingAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    AmountForInterests = table.Column<decimal>(type: "money", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingAccounts", x => x.SavingAccountID);
                    table.ForeignKey(
                        name: "FK_SavingAccounts_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    LoanInterestID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTerms = table.Column<int>(type: "int", nullable: false),
                    LoanAmount = table.Column<decimal>(type: "money", nullable: false),
                    Interests = table.Column<decimal>(type: "money", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    DueAmount = table.Column<decimal>(type: "money", nullable: false),
                    TermAmount = table.Column<decimal>(type: "money", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCurrent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanID);
                    table.ForeignKey(
                        name: "FK_Loans_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_LoanInterests_LoanInterestID",
                        column: x => x.LoanInterestID,
                        principalTable: "LoanInterests",
                        principalColumn: "LoanInterestID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubPeriods",
                columns: table => new
                {
                    SubPeriodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriodID = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPeriods", x => x.SubPeriodID);
                    table.ForeignKey(
                        name: "FK_SubPeriods_Periods_PeriodID",
                        column: x => x.PeriodID,
                        principalTable: "Periods",
                        principalColumn: "PeriodID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LoanInstallments",
                columns: table => new
                {
                    LoanInstallmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanID = table.Column<int>(type: "int", nullable: false),
                    SubPeriodID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    DueAmount = table.Column<decimal>(type: "money", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePaid = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanInstallments", x => x.LoanInstallmentID);
                    table.ForeignKey(
                        name: "FK_LoanInstallments_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LoanInstallments_SubPeriods_SubPeriodID",
                        column: x => x.SubPeriodID,
                        principalTable: "SubPeriods",
                        principalColumn: "SubPeriodID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LoanPaymentHistory",
                columns: table => new
                {
                    LoanHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanID = table.Column<int>(type: "int", nullable: false),
                    SubPeriodID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    IsExtraPayment = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanPaymentHistory", x => x.LoanHistoryID);
                    table.ForeignKey(
                        name: "FK_LoanPaymentHistory_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LoanPaymentHistory_SubPeriods_SubPeriodID",
                        column: x => x.SubPeriodID,
                        principalTable: "SubPeriods",
                        principalColumn: "SubPeriodID");
                });

            migrationBuilder.CreateTable(
                name: "SavingAccountDeposits",
                columns: table => new
                {
                    SavingAccountDepositID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavingAccountID = table.Column<int>(type: "int", nullable: false),
                    SubPeriodID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingAccountDeposits", x => x.SavingAccountDepositID);
                    table.ForeignKey(
                        name: "FK_SavingAccountDeposits_SavingAccounts_SavingAccountID",
                        column: x => x.SavingAccountID,
                        principalTable: "SavingAccounts",
                        principalColumn: "SavingAccountID",
                        onDelete: ReferentialAction.NoAction);   
                    table.ForeignKey(
                        name: "FK_SavingAccountDeposits_SubPeriods_SubPeriodID",
                        column: x => x.SubPeriodID,
                        principalTable: "SubPeriods",
                        principalColumn: "SubPeriodID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SavingAccountWidthdrawals",
                columns: table => new
                {
                    SavingAccountWithdrawalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavingAccountID = table.Column<int>(type: "int", nullable: false),
                    SubPeriodID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingAccountWidthdrawals", x => x.SavingAccountWithdrawalID);
                    table.ForeignKey(
                        name: "FK_SavingAccountWidthdrawals_SavingAccounts_SavingAccountID",
                        column: x => x.SavingAccountID,
                        principalTable: "SavingAccounts",
                        principalColumn: "SavingAccountID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SavingAccountWidthdrawals_SubPeriods_SubPeriodID",
                        column: x => x.SubPeriodID,
                        principalTable: "SubPeriods",
                        principalColumn: "SubPeriodID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CompanyID",
                table: "Clients",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_InterestRanges_CompanyID",
                table: "InterestRanges",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanInstallments_LoanID",
                table: "LoanInstallments",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanInstallments_SubPeriodID",
                table: "LoanInstallments",
                column: "SubPeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanInterests_CompanyID",
                table: "LoanInterests",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanPaymentHistory_LoanID",
                table: "LoanPaymentHistory",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanPaymentHistory_SubPeriodID",
                table: "LoanPaymentHistory",
                column: "SubPeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ClientID",
                table: "Loans",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanInterestID",
                table: "Loans",
                column: "LoanInterestID");

            migrationBuilder.CreateIndex(
                name: "IX_Periods_CompanyID",
                table: "Periods",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccountDeposits_SavingAccountID",
                table: "SavingAccountDeposits",
                column: "SavingAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccountDeposits_SubPeriodID",
                table: "SavingAccountDeposits",
                column: "SubPeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccounts_ClientID",
                table: "SavingAccounts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccountWidthdrawals_SavingAccountID",
                table: "SavingAccountWidthdrawals",
                column: "SavingAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_SavingAccountWidthdrawals_SubPeriodID",
                table: "SavingAccountWidthdrawals",
                column: "SubPeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_SubPeriods_PeriodID",
                table: "SubPeriods",
                column: "PeriodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestRanges");

            migrationBuilder.DropTable(
                name: "LoanInstallments");

            migrationBuilder.DropTable(
                name: "LoanPaymentHistory");

            migrationBuilder.DropTable(
                name: "SavingAccountDeposits");

            migrationBuilder.DropTable(
                name: "SavingAccountWidthdrawals");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "SavingAccounts");

            migrationBuilder.DropTable(
                name: "SubPeriods");

            migrationBuilder.DropTable(
                name: "LoanInterests");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
