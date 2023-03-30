using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationDatesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 3, 30, 10, 24, 9, 899, DateTimeKind.Local).AddTicks(3280));
        }
    }
}
