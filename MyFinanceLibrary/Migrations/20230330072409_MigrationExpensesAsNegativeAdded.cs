using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationExpensesAsNegativeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -1000m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -100m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -10m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -1m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -1000m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -100m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -10m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -1m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -1000m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Amount", "Date" },
                values: new object[] { -100m, new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3280) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 100m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 100m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1000m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 100m, new DateTime(2023, 3, 30, 9, 56, 54, 770, DateTimeKind.Local).AddTicks(9573) });
        }
    }
}
