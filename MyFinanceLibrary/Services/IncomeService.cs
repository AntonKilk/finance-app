using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class IncomeService : IIncomeService
    {
        MyFinanceContext _context;

        public IncomeService(MyFinanceContext context)
        {
            _context = context;
        }

        public async Task<List<IncomeType>> GetIncomeTypes()
        {
            return await _context.IncomeTypes.ToListAsync();
        }

        public async Task<IncomeType?> GetIncomeType(int id)
        {
            return await _context.IncomeTypes.FindAsync(id);
        }

        public async Task<IncomeType> CreateIncomeType(IncomeType incomeType)
        {
            _context.IncomeTypes.Add(incomeType);
            await _context.SaveChangesAsync();

            return incomeType;
        }

        public async Task<bool> UpdateIncomeType(int id, IncomeType incomeType)
        {
            if (id != incomeType.ID)
            {
                return false;
            }

            _context.Entry(incomeType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomeTypeExists(id))
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

        public async Task<bool> DeleteIncomeType(int id)
        {
            var incomeType = await _context.IncomeTypes.FindAsync(id);
            if (incomeType == null)
            {
                return false;
            }

            _context.IncomeTypes.Remove(incomeType);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool IncomeTypeExists(int id)
        {
            return _context.IncomeTypes.Any(e => e.ID == id);
        }
    }

}
