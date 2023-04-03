using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrateFinancialOperationAddedIsDel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDel",
                table: "FinancialOperations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "IsDel",
                value: false);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "IsDel",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDel",
                table: "FinancialOperations");
        }
    }
}
