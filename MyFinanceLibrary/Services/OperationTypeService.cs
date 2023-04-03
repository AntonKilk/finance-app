using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class OperationTypeService : IOperationTypeService
    {
        MyFinanceContext _context;
        public OperationTypeService(MyFinanceContext context)
        {
            _context = context;
        }
        public async Task<List<OperationType>> GetOperationTypes()
        {
            return await _context.OperationTypes.ToListAsync();
        }
        public async Task<OperationType?> GetOperationType(int id)
        {
            return await _context.OperationTypes.FindAsync(id);
        }
        public async Task<OperationType> CreateOperationType(OperationType operationType)
        {
            _context.OperationTypes.Add(operationType);
            await _context.SaveChangesAsync();
            return operationType;
        }
        public async Task<bool> UpdateOperationType(int id, OperationType operationType)
        {
            if (id != operationType.ID)
            {
                return false;
            }
            _context.Entry(operationType).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperationTypeExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }
        public async Task<bool> DeleteOperationType(int id)
        {
            var operationType = await _context.OperationTypes.FindAsync(id);
            if (operationType == null)
            {
                return false;
            }
            _context.OperationTypes.Remove(operationType);
            await _context.SaveChangesAsync();
            return true;
        }
        private bool OperationTypeExists(int id)
        {
            return _context.OperationTypes.Any(e => e.ID == id);
        }
    }   
}
