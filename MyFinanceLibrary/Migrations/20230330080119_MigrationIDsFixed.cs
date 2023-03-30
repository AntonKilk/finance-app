using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationIDsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "IncomeTypeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "IncomeTypeID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "IncomeTypeID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "IncomeTypeID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "IncomeTypeID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "ExpenseTypeID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "ExpenseTypeID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "ExpenseTypeID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "ExpenseTypeID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "ExpenseTypeID",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 6, "Food" },
                    { 7, "Transport" },
                    { 8, "Housing" },
                    { 9, "Clothing" },
                    { 10, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "IncomeTypeID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "IncomeTypeID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "IncomeTypeID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "IncomeTypeID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "IncomeTypeID",
                value: 10);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "ExpenseTypeID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "ExpenseTypeID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "ExpenseTypeID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "ExpenseTypeID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "ExpenseTypeID",
                value: 10);

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 6, "Salary" },
                    { 7, "Gift" },
                    { 8, "Interest" },
                    { 9, "Bonus" },
                    { 10, "Other" }
                });
        }
    }
}
