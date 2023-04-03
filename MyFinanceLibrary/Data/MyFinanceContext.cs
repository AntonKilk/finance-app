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

        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<FinancialOperation> FinancialOperations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperationType>().HasData(
                new OperationType { ID = 1, Name = "Salary", isIncome = true },
                new OperationType { ID = 2, Name = "Gift", isIncome = true },
                new OperationType { ID = 3, Name = "Interest", isIncome = true },
                new OperationType { ID = 4, Name = "Bonus", isIncome = true },
                new OperationType { ID = 5, Name = "Other", isIncome = true },
                new OperationType { ID = 6, Name = "Food", isIncome = false },
                new OperationType { ID = 7, Name = "Transport", isIncome = false },
                new OperationType { ID = 8, Name = "Housing", isIncome = false },
                new OperationType { ID = 9, Name = "Clothing", isIncome = false },
                new OperationType { ID = 10, Name = "Other", isIncome = false }
            );
            modelBuilder.Entity<FinancialOperation>().HasData(
                new FinancialOperation { ID = 1, OperationTypeID = 1, Amount = 10000, Date = DateTime.Parse("2023-03-15"), Comment = "Salary March" },
                new FinancialOperation { ID = 2, OperationTypeID = 2, Amount = 1000, Date = DateTime.Parse("2023-03-16"), Comment = "Birthday gift" },
                new FinancialOperation { ID = 3, OperationTypeID = 3, Amount = 100, Date = DateTime.Parse("2023-03-17"), Comment = "Tesla shares" },
                new FinancialOperation { ID = 4, OperationTypeID = 4, Amount = 10, Date = DateTime.Parse("2023-03-18"), Comment = "bonus1" },
                new FinancialOperation { ID = 5, OperationTypeID = 5, Amount = 1, Date = DateTime.Parse("2023-03-19"), Comment = "Rental income" },
                new FinancialOperation { ID = 6, OperationTypeID = 1, Amount = 10000, Date = DateTime.Parse("2023-03-20"), Comment = "Another gift" },
                new FinancialOperation { ID = 7, OperationTypeID = 2, Amount = 1000, Date = DateTime.Parse("2023-03-21"), Comment = "Microsoft shares" },
                new FinancialOperation { ID = 8, OperationTypeID = 3, Amount = 100, Date = DateTime.Parse("2023-03-22"), Comment = "more money" },
                new FinancialOperation { ID = 9, OperationTypeID = 4, Amount = 10, Date = DateTime.Parse("2023-03-23"), Comment = "bonus2" },
                new FinancialOperation { ID = 10, OperationTypeID = 5, Amount = 1, Date = DateTime.Parse("2023-03-24"), Comment = "additional income" },
                new FinancialOperation { ID = 11, OperationTypeID = 6, Amount = -1000, Date = DateTime.Parse("2023-03-25"), Comment = "grocery1" },
                new FinancialOperation { ID = 12, OperationTypeID = 7, Amount = -100, Date = DateTime.Parse("2023-03-26"), Comment = "gasoline1" },
                new FinancialOperation { ID = 13, OperationTypeID = 8, Amount = -10, Date = DateTime.Parse("2023-03-27"), Comment = "rental1" },
                new FinancialOperation { ID = 14, OperationTypeID = 9, Amount = -1, Date = DateTime.Parse("2023-03-28"), Comment = "kids clothing" },
                new FinancialOperation { ID = 15, OperationTypeID = 10, Amount = -1000, Date = DateTime.Parse("2023-03-29"), Comment = "shopping1" },
                new FinancialOperation { ID = 16, OperationTypeID = 6, Amount = -100, Date = DateTime.Parse("2023-03-30"), Comment = "grocery1" },
                new FinancialOperation { ID = 17, OperationTypeID = 7, Amount = -10, Date = DateTime.Parse("2023-03-30"), Comment = "bus" },
                new FinancialOperation { ID = 18, OperationTypeID = 8, Amount = -1, Date = DateTime.Parse("2023-03-30"), Comment = "rental1" },
                new FinancialOperation { ID = 19, OperationTypeID = 9, Amount = -1000, Date = DateTime.Parse("2023-03-30"), Comment = "H&M" },
                new FinancialOperation { ID = 20, OperationTypeID = 10, Amount = -100, Date = DateTime.Parse("2023-03-30"), Comment = "shopping2" }
            );
        }
    }
}
