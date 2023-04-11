using MyFinanceLibrary.Models;

namespace MyFinanceBlazor.Services.Interfaces
{
    public interface IFinancialOperationService
    {   
        Task<List<FinancialOperation>> GetOperations();
        Task<FinancialOperation> GetOperation(int id);
        Task<FinancialOperation> AddOperation(FinancialOperation operation);
        Task DeleteOperation(int id);
        Task UpdateOperation(FinancialOperation operation);
    }
}
