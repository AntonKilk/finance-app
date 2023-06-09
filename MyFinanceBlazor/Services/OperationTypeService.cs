﻿using MyFinanceLibrary.Models;
using MyFinanceBlazor.Services.Interfaces;

namespace MyFinanceBlazor.Services
{
    public class OperationTypeService : IOperationTypeService
    {
        private readonly MyHttpService _httpService;

        public OperationTypeService(MyHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<OperationType>> GetOperationTypes()
        {
            return await _httpService.GetAsync<List<OperationType>>("/OperationType");
        }

        public async Task<OperationType> GetOperationType(int id)
        {
            return await _httpService.GetAsync<OperationType>($"/OperationType/{id}");
        }

        public async Task<OperationType> AddOperationType(OperationType operationType)
        {
            return await _httpService.PostAsync<OperationType>("/OperationType", operationType);
        }

        public async Task UpdateOperationType(int id, OperationType operationType)
        {
            await _httpService.PutAsync($"/OperationType/{id}", operationType);
        }

        public async Task DeleteOperationType(int id)
        {
            await _httpService.DeleteAsync($"/OperationType/{id}");
        }
    }
}
