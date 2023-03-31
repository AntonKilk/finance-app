using MyFinanceLibrary.Models;

namespace MyFinanceLibrary.Services.Interfaces
{
    public interface IExpenseService
    {
        Task<List<ExpenseType>> GetExpenseTypes();
        Task<ExpenseType?> GetExpenseType(int id);
        Task<ExpenseType> CreateExpenseType(ExpenseType expenseType);
        Task<bool> UpdateExpenseType(int id, ExpenseType expenseType);
        Task<bool> DeleteExpenseType(int id);
    }
}
