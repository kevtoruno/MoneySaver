using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLServerMigrations.Migrations
{
    /// <inheritdoc />
    public partial class BeneficiaryFieldsForSavingAccountAndCKCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryAddress",
                table: "SavingAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryLastNames",
                table: "SavingAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryNames",
                table: "SavingAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "SavingAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryRelationship",
                table: "SavingAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CKCode",
                table: "Loans",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CKCode",
                table: "Loans",
                column: "CKCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Loans_CKCode",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "BeneficiaryAddress",
                table: "SavingAccounts");

            migrationBuilder.DropColumn(
                name: "BeneficiaryLastNames",
                table: "SavingAccounts");

            migrationBuilder.DropColumn(
                name: "BeneficiaryNames",
                table: "SavingAccounts");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPhoneNumber",
                table: "SavingAccounts");

            migrationBuilder.DropColumn(
                name: "BeneficiaryRelationship",
                table: "SavingAccounts");

            migrationBuilder.DropColumn(
                name: "CKCode",
                table: "Loans");
        }
    }
}
