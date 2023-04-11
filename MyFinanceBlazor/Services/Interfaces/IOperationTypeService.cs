using MyFinanceLibrary.Models;

namespace MyFinanceBlazor.Services.Interfaces
{
    public interface IOperationTypeService
    {
        Task<List<OperationType>> GetOperationTypes();
        Task<OperationType> GetOperationType(int id);
        Task<OperationType> AddOperationType(OperationType operationType);
        Task DeleteOperationType(int id);
        Task UpdateOperationType(int id, OperationType operationType);
    }
}
