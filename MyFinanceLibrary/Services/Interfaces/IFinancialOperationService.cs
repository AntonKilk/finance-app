using MyFinanceLibrary.Models;

namespace MyFinanceLibrary.Services.Interfaces
{
    public interface IFinancialOperationService
    {
        Task<List<FinancialOperation>> GetFinancialOperations();
        Task<FinancialOperation?> GetFinancialOperation(int id);
        Task<FinancialOperation> CreateFinancialOperation(FinancialOperation financialOp);
        Task<bool> UpdateFinancialOperation(int id, FinancialOperation financialOperation);
        Task<bool> DeleteFinancialOperation(int id);
    }
}
