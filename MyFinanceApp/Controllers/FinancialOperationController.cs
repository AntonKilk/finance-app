using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinancialOperationController : Controller
    {
        private readonly MyFinanceContext _context;

        public FinancialOperationController(MyFinanceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialOperation>>> GetFinancialOperations()
        {
            return await _context.FinancialOperations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialOperation>> GetFinancialOperation(int id)
        {
            var financialOperation = await _context.FinancialOperations.FindAsync(id);

            if (financialOperation == null)
            {
                return NotFound();
            }

            return financialOperation;
        }

        [HttpPost]
        public async Task<ActionResult<FinancialOperation>> CreateFinancialOperation(FinancialOperation financialOperation)
        {
            _context.FinancialOperations.Add(financialOperation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFinancialOperation), new { id = financialOperation.ID }, financialOperation);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFinancialOperation(int id, FinancialOperation financialOperation)
        {
            if (id != financialOperation.ID)
            {
                return BadRequest();
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
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinancialOperation(int id)
        {
            var financialOperation = await _context.FinancialOperations.FindAsync(id);
            if (financialOperation == null)
            {
                return NotFound();
            }

            _context.FinancialOperations.Remove(financialOperation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FinancialOperationExists(int id)
        {
            return _context.FinancialOperations.Any(e => e.ID == id);
        }
    }
}
