using MyFinanceLibrary.Models;
using MyFinanceBlazor.Services.Interfaces;

namespace MyFinanceBlazor.Services
{
    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly MyHttpService _httpService;

        public FinancialOperationService(MyHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<FinancialOperation>> GetOperations()
        {
            return await _httpService.GetAsync<List<FinancialOperation>>("https://localhost:7295/FinancialOperation");
        }

        public async Task<FinancialOperation> GetOperation(int id)
        {
            return await _httpService.GetAsync<FinancialOperation>($"https://localhost:7295/FinancialOperation/{id}");
        }

        public async Task<FinancialOperation> AddOperation(FinancialOperation operation)
        {
            return await _httpService.PostAsync<FinancialOperation>("https://localhost:7295/FinancialOperation", operation);
        }

        public async Task<FinancialOperation> UpdateOperation(int id, FinancialOperation operation)
        {
            return await _httpService.PostAsync<FinancialOperation>($"https://localhost:7295/FinancialOperation/{id}", operation);
        }

        public async Task DeleteOperation(int id)
        {
            await _httpService.PostAsync<object>($"https://localhost:7295/FinancialOperation/delete/{id}", null);
        }
    }

}
