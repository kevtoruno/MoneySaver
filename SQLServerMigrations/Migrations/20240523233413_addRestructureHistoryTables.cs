using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLServerMigrations.Migrations
{
    /// <inheritdoc />
    public partial class addRestructureHistoryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanRestructureHistory",
                columns: table => new
                {
                    LoanRestructureHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanID = table.Column<int>(type: "int", nullable: false),
                    PreviousTotalTerms = table.Column<int>(type: "int", nullable: false),
                    NewTotalTerms = table.Column<int>(type: "int", nullable: false),
                    PreviousTermAmount = table.Column<decimal>(type: "money", nullable: false),
                    NewTermAmount = table.Column<decimal>(type: "money", nullable: false),
                    DisabledTerms = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRestructureHistory", x => x.LoanRestructureHistoryID);
                    table.ForeignKey(
                        name: "FK_LoanRestructureHistory_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanRestructureInstallmentsHistory",
                columns: table => new
                {
                    LoanRestructureInstallmentsHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanRestructureHistoryID = table.Column<int>(type: "int", nullable: false),
                    LoanInstallmentID = table.Column<int>(type: "int", nullable: false),
                    SubPeriodID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    DueAmount = table.Column<decimal>(type: "money", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRestructureInstallmentsHistory", x => x.LoanRestructureInstallmentsHistoryID);
                    table.ForeignKey(
                        name: "FK_LoanRestructureInstallmentsHistory_LoanRestructureHistory_LoanRestructureHistoryID",
                        column: x => x.LoanRestructureHistoryID,
                        principalTable: "LoanRestructureHistory",
                        principalColumn: "LoanRestructureHistoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanRestructureInstallmentsHistory_SubPeriods_SubPeriodID",
                        column: x => x.SubPeriodID,
                        principalTable: "SubPeriods",
                        principalColumn: "SubPeriodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanRestructureHistory_LoanID",
                table: "LoanRestructureHistory",
                column: "LoanID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRestructureInstallmentsHistory_LoanRestructureHistoryID",
                table: "LoanRestructureInstallmentsHistory",
                column: "LoanRestructureHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRestructureInstallmentsHistory_SubPeriodID",
                table: "LoanRestructureInstallmentsHistory",
                column: "SubPeriodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanRestructureInstallmentsHistory");

            migrationBuilder.DropTable(
                name: "LoanRestructureHistory");
        }
    }
}
