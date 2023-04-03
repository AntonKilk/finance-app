using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class FinancialOperationService : IFinancialOperationService
    {
        MyFinanceContext _context;
        public FinancialOperationService(MyFinanceContext context)
        {
            _context = context;
        }

        public async Task<List<FinancialOperation>> GetFinancialOperations()
        {
            var financialOperatios = await _context.FinancialOperations.Where(x => x.IsDel == false).ToListAsync();
            return financialOperatios;
        }

        public async Task<FinancialOperation?> GetFinancialOperation(int id)
        {
            return await _context.FinancialOperations.FindAsync(id);
        }

        public async Task<FinancialOperation> CreateFinancialOperation(FinancialOperation financialOp)
        {
            _context.FinancialOperations.Add(financialOp);
            await _context.SaveChangesAsync();
            return financialOp;
        }

        public async Task<bool> UpdateFinancialOperation(int id, FinancialOperation financialOperation)
        {
            if (id != financialOperation.ID)
            {
                return false;
            }

            _context.Entry(financialOperation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinancialOperationExists(id))
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

        public async Task<bool> DeleteFinancialOperation(int id)
        {
            var financialOperation = await _context.FinancialOperations.FindAsync(id);

            if (financialOperation == null)
            {
                return false;
            }

            financialOperation.IsDel = true;
            await _context.SaveChangesAsync();
            return true;
        }

        private bool FinancialOperationExists(int id)
        {
            return _context.FinancialOperations.Any(e => e.ID == id);
        }
    }
}
