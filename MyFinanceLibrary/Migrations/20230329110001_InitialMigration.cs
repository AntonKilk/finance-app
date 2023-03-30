using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFinanceLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeTypes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "ID", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Food", 100.0 },
                    { 2, "Transport", 100.0 },
                    { 3, "Housing", 100.0 },
                    { 4, "Clothing", 100.0 },
                    { 5, "Other", 100.0 },
                    { 6, "Food", 100.0 },
                    { 7, "Transport", 100.0 },
                    { 8, "Housing", 100.0 },
                    { 9, "Clothing", 100.0 },
                    { 10, "Other", 100.0 }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "ID", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Salary", 1000.0 },
                    { 2, "Gift", 100.0 },
                    { 3, "Interest", 10.0 },
                    { 4, "Bonus", 500.0 },
                    { 5, "Other", 0.0 },
                    { 6, "Salary", 1000.0 },
                    { 7, "Gift", 100.0 },
                    { 8, "Interest", 10.0 },
                    { 9, "Bonus", 500.0 },
                    { 10, "Other", 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "IncomeTypes");
        }
    }
}
