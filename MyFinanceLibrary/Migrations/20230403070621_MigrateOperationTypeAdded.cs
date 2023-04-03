using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class MigrateOperationTypeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "IncomeTypes");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeID",
                table: "FinancialOperations");

            migrationBuilder.RenameColumn(
                name: "IncomeTypeID",
                table: "FinancialOperations",
                newName: "OperationTypeID");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "FinancialOperations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OperationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isIncome = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypes", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Comment",
                value: "Salary March");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Comment",
                value: "Birthday gift");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Comment",
                value: "Tesla shares");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "Comment",
                value: "bonus1");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "Comment",
                value: "Rental income");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "Comment",
                value: "Another gift");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "Comment",
                value: "Microsoft shares");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "Comment",
                value: "more money");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "Comment",
                value: "bonus2");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "Comment",
                value: "additional income");

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "grocery1", 6 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "gasoline1", 7 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "rental1", 8 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "kids clothing", 9 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "shopping1", 10 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "grocery1", 6 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "bus", 7 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "rental1", 8 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "H&M", 9 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Comment", "OperationTypeID" },
                values: new object[] { "shopping2", 10 });

            migrationBuilder.InsertData(
                table: "OperationTypes",
                columns: new[] { "ID", "Name", "isIncome" },
                values: new object[,]
                {
                    { 1, "Salary", true },
                    { 2, "Gift", true },
                    { 3, "Interest", true },
                    { 4, "Bonus", true },
                    { 5, "Other", true },
                    { 6, "Food", false },
                    { 7, "Transport", false },
                    { 8, "Housing", false },
                    { 9, "Clothing", false },
                    { 10, "Other", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationTypes");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "FinancialOperations");

            migrationBuilder.RenameColumn(
                name: "OperationTypeID",
                table: "FinancialOperations",
                newName: "IncomeTypeID");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeID",
                table: "FinancialOperations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IncomeTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Transport" },
                    { 3, "Housing" },
                    { 4, "Clothing" },
                    { 5, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 1,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 2,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 3,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 4,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 5,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 6,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 7,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 8,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 9,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 10,
                column: "ExpenseTypeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "FinancialOperations",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "ExpenseTypeID", "IncomeTypeID" },
                values: new object[] { 5, 0 });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Salary" },
                    { 2, "Gift" },
                    { 3, "Interest" },
                    { 4, "Bonus" },
                    { 5, "Other" }
                });
        }
    }
}
