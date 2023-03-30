using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class ExpenseService : IExpenseService
    {
        MyFinanceContext _db;
        public ExpenseService(MyFinanceContext context)
        {
            _db = context;
        }

        public async Task<List<ExpenseType>> GetExpenseTypes()
        {
            return await _db.ExpenseTypes.ToListAsync();
        }

        public async Task<ExpenseType> GetExpenseType(int id)
        {
            return await _db.ExpenseTypes.FindAsync(id);
        }

        public async Task<ExpenseType> CreateExpenseType(ExpenseType expenseType)
        {
            _db.ExpenseTypes.Add(expenseType);
            await _db.SaveChangesAsync();

            return expenseType;
        }

        public async Task<bool> UpdateExpenseType(int id, ExpenseType expenseType)
        {
            if (id != expenseType.ID)
            {
                return false;
            }

            _db.Entry(expenseType).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
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
            var expenseType = await _db.ExpenseTypes.FindAsync(id);

            if (expenseType == null)
            {
                return false;
            }
            _db.ExpenseTypes.Remove(expenseType);
            await _db.SaveChangesAsync();

            return true;
        }
        private bool ExpenseTypeExists(int id)
        {
            return _db.ExpenseTypes.Any(e => e.ID == id);
        }
    }
}
