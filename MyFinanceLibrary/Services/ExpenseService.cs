using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class ExpenseService : IExpenseService
    {
        MyFinanceContext _context;
        public ExpenseService(MyFinanceContext context)
        {
            _context = context;
        }

        public async Task<List<ExpenseType>> GetExpenseTypes()
        {
            return await _context.ExpenseTypes.ToListAsync();
        }

        public async Task<ExpenseType?> GetExpenseType(int id)
        {
            return await _context.ExpenseTypes.FindAsync(id);
        }

        public async Task<ExpenseType> CreateExpenseType(ExpenseType expenseType)
        {
            _context.ExpenseTypes.Add(expenseType);
            await _context.SaveChangesAsync();

            return expenseType;
        }

        public async Task<bool> UpdateExpenseType(int id, ExpenseType expenseType)
        {
            if (id != expenseType.ID)
            {
                return false;
            }

            _context.Entry(expenseType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseTypeExists(id))
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

        public async Task<bool> DeleteExpenseType(int id)
        {
            var expenseType = await _context.ExpenseTypes.FindAsync(id);

            if (expenseType == null)
            {
                return false;
            }
            _context.ExpenseTypes.Remove(expenseType);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool ExpenseTypeExists(int id)
        {
            return _context.ExpenseTypes.Any(e => e.ID == id);
        }
    }
}
