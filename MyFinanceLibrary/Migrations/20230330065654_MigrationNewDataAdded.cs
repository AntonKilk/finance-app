using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNewDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "IncomeTypes");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ExpenseTypes");

            migrationBuilder.CreateTable(
                name: "FinancialOperations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeTypeID = table.Column<int>(type: "int", nullable: false),
                    ExpenseTypeID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialOperations", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "FinancialOperations",
                columns: new[] { "ID", "Amount", "Balance", "Date", "ExpenseTypeID", "IncomeTypeID" },
                values: new object[,]
                {
                    { 1, 10000m, 10000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9468), 0, 1 },
                    { 2, 1000m, 11000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9526), 0, 2 },
                    { 3, 100m, 11100m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9529), 0, 3 },
                    { 4, 10m, 11110m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9531), 0, 4 },
                    { 5, 1m, 11111m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9535), 0, 5 },
                    { 6, 10000m, 21111m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9539), 0, 6 },
                    { 7, 1000m, 22111m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9541), 0, 7 },
                    { 8, 100m, 22211m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9543), 0, 8 },
                    { 9, 10m, 22221m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9547), 0, 9 },
                    { 10, 1m, 22222m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9549), 0, 10 },
                    { 11, 1000m, 21222m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9551), 1, 0 },
                    { 12, 100m, 21122m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9554), 2, 0 },
                    { 13, 10m, 21112m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9556), 3, 0 },
                    { 14, 1m, 21111m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9558), 4, 0 },
                    { 15, 1000m, 20111m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9561), 5, 0 },
                    { 16, 100m, 20011m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9563), 6, 0 },
                    { 17, 10m, 20001m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9566), 7, 0 },
                    { 18, 1m, 20000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9568), 8, 0 },
                    { 19, 1000m, 19000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9570), 9, 0 },
                    { 20, 100m, 18900m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9573), 10, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialOperations");

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "IncomeTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "ExpenseTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 3,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 4,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 5,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 6,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 7,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 8,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 9,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ID",
                keyValue: 10,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 1,
                column: "Value",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 2,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 3,
                column: "Value",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 4,
                column: "Value",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 5,
                column: "Value",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 6,
                column: "Value",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 7,
                column: "Value",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 8,
                column: "Value",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 9,
                column: "Value",
                value: 500.0);

            migrationBuilder.UpdateData(
                table: "IncomeTypes",
                keyColumn: "ID",
                keyValue: 10,
                column: "Value",
                value: 0.0);
        }
    }
}
