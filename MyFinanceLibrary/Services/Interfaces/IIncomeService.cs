using MyFinanceLibrary.Models;

namespace MyFinanceLibrary.Services.Interfaces
{
    public interface IIncomeService
    {
        Task<List<IncomeType>> GetIncomeTypes();
        Task<IncomeType> GetIncomeType(int id);
        Task<IncomeType> CreateIncomeType(IncomeType expenseType);
        Task<bool> UpdateIncomeType(int id, IncomeType expenseType);
        Task<bool> DeleteIncomeType(int id);
    }
}
