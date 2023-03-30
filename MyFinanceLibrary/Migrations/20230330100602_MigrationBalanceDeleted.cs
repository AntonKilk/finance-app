using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationBalanceDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "FinancialOperations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "FinancialOperations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Balance",
                value: 10000m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Balance",
                value: 11000m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Balance",
                value: 11100m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Balance",
                value: 11110m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "Balance",
                value: 11111m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "Balance",
                value: 21111m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "Balance",
                value: 22111m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "Balance",
                value: 22211m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "Balance",
                value: 22221m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "Balance",
                value: 22222m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                column: "Balance",
                value: 21222m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                column: "Balance",
                value: 21122m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                column: "Balance",
                value: 21112m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                column: "Balance",
                value: 21111m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                column: "Balance",
                value: 20111m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "Balance",
                value: 20011m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "Balance",
                value: 20001m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "Balance",
                value: 20000m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "Balance",
                value: 19000m);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "Balance",
                value: 18900m);
        }
    }
}
