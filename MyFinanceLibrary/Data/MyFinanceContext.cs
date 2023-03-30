using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Models;

namespace MyFinanceLibrary.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext(DbContextOptions<MyFinanceContext> options)
            : base(options)
        {
        }

        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<FinancialOperation> FinancialOperations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncomeType>().HasData(
                new IncomeType { ID = 1, Name = "Salary" },
                new IncomeType { ID = 2, Name = "Gift" },
                new IncomeType { ID = 3, Name = "Interest" },
                new IncomeType { ID = 4, Name = "Bonus" },
                new IncomeType { ID = 5, Name = "Other" }
            );
            modelBuilder.Entity<ExpenseType>().HasData(
                new ExpenseType { ID = 1, Name = "Food" },
                new ExpenseType { ID = 2, Name = "Transport" },
                new ExpenseType { ID = 3, Name = "Housing" },
                new ExpenseType { ID = 4, Name = "Clothing" },
                new ExpenseType { ID = 5, Name = "Other" }
            );
            modelBuilder.Entity<FinancialOperation>().HasData(
                new FinancialOperation { ID = 1, IncomeTypeID = 1, Amount = 10000, Date = DateTime.Parse("2023-03-15") },
                new FinancialOperation { ID = 2, IncomeTypeID = 2, Amount = 1000, Date = DateTime.Parse("2023-03-16") },
                new FinancialOperation { ID = 3, IncomeTypeID = 3, Amount = 100, Date = DateTime.Parse("2023-03-17") },
                new FinancialOperation { ID = 4, IncomeTypeID = 4, Amount = 10, Date = DateTime.Parse("2023-03-18") },
                new FinancialOperation { ID = 5, IncomeTypeID = 5, Amount = 1, Date = DateTime.Parse("2023-03-19") },
                new FinancialOperation { ID = 6, IncomeTypeID = 1, Amount = 10000, Date = DateTime.Parse("2023-03-20") },
                new FinancialOperation { ID = 7, IncomeTypeID = 2, Amount = 1000, Date = DateTime.Parse("2023-03-21") },
                new FinancialOperation { ID = 8, IncomeTypeID = 3, Amount = 100, Date = DateTime.Parse("2023-03-22") },
                new FinancialOperation { ID = 9, IncomeTypeID = 4, Amount = 10, Date = DateTime.Parse("2023-03-23") },
                new FinancialOperation { ID = 10, IncomeTypeID = 5, Amount = 1, Date = DateTime.Parse("2023-03-24") },
                new FinancialOperation { ID = 11, ExpenseTypeID = 1, Amount = -1000, Date = DateTime.Parse("2023-03-25") },
                new FinancialOperation { ID = 12, ExpenseTypeID = 2, Amount = -100, Date = DateTime.Parse("2023-03-26") },
                new FinancialOperation { ID = 13, ExpenseTypeID = 3, Amount = -10, Date = DateTime.Parse("2023-03-27") },
                new FinancialOperation { ID = 14, ExpenseTypeID = 4, Amount = -1, Date = DateTime.Parse("2023-03-28") },
                new FinancialOperation { ID = 15, ExpenseTypeID = 5, Amount = -1000, Date = DateTime.Parse("2023-03-29") },
                new FinancialOperation { ID = 16, ExpenseTypeID = 1, Amount = -100, Date = DateTime.Parse("2023-03-30") },
                new FinancialOperation { ID = 17, ExpenseTypeID = 2, Amount = -10, Date = DateTime.Parse("2023-03-30") },
                new FinancialOperation { ID = 18, ExpenseTypeID = 3, Amount = -1, Date = DateTime.Parse("2023-03-30") },
                new FinancialOperation { ID = 19, ExpenseTypeID = 4, Amount = -1000, Date = DateTime.Parse("2023-03-30") },
                new FinancialOperation { ID = 20, ExpenseTypeID = 5, Amount = -100, Date = DateTime.Parse("2023-03-30") }
            );
        }
    }
}
