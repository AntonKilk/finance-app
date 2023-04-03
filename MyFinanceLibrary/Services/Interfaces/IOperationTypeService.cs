using MyFinanceLibrary.Models;

namespace MyFinanceLibrary.Services.Interfaces
{
    public interface IOperationTypeService
    {
        Task<List<OperationType>> GetOperationTypes();
        Task<OperationType?> GetOperationType(int id);
        Task<OperationType> CreateOperationType(OperationType operationType);
        Task<bool> UpdateOperationType(int id, OperationType operationType);
        Task<bool> DeleteOperationType(int id);
    }
}
