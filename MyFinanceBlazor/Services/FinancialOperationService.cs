using MyFinanceLibrary.Models;
using MyFinanceBlazor.Services.Interfaces;
using Azure;

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
            return await _httpService.GetAsync<List<FinancialOperation>>("/FinancialOperation");
        }

        public async Task<FinancialOperation> GetOperation(int id)
        {
            return await _httpService.GetAsync<FinancialOperation>($"/FinancialOperation/{id}");
        }

        public async Task<FinancialOperation> AddOperation(FinancialOperation operation)
        {
            return await _httpService.PostAsync<FinancialOperation>("/FinancialOperation", operation);
        }

        public async Task UpdateOperation(FinancialOperation operation)
        {
            await _httpService.PutAsync($"/FinancialOperation/{operation.ID}", operation);
        }

        public async Task DeleteOperation(int id)
        {
            await _httpService.DeleteAsync($"/FinancialOperation/{id}");
        }
    }

}
