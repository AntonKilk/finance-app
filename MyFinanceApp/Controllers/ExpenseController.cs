using Microsoft.AspNetCore.Mvc;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseType>>> GetExpenseTypes()
        {
            return await _expenseService.GetExpenseTypes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseType>> GetExpenseType(int id)
        {
            var expenseType = await _expenseService.GetExpenseType(id);

            if (expenseType == null)
            {
                return NotFound();
            }

            return expenseType;
        }

        [HttpPost]
        public async Task<ActionResult<ExpenseType>> CreateExpenseType(ExpenseType expenseType)
        {
            var createdExpenseType = await _expenseService.CreateExpenseType(expenseType);

            return CreatedAtAction(nameof(GetExpenseType), new { id = createdExpenseType.ID }, createdExpenseType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateExpenseType(int id, ExpenseType expenseType)
        {
            bool success = await _expenseService.UpdateExpenseType(id, expenseType);
            if (!success)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseType(int id)
        {
            bool success = await _expenseService.DeleteExpenseType(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
