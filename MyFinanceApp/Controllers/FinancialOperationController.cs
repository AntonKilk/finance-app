using Microsoft.AspNetCore.Mvc;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinancialOperationController : Controller
    {
        IFinancialOperationService _financialOp;

        public FinancialOperationController(IFinancialOperationService financialOp)
        {
            _financialOp = financialOp;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialOperation>>> GetFinancialOperations()
        {
            return await _financialOp.GetFinancialOperations();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialOperation>> GetFinancialOperation(int id)
        {
            var financialOp = await _financialOp.GetFinancialOperation(id);

            if (financialOp == null)
            {
                return NotFound();
            }

            return financialOp;
        }

        [HttpPost]
        public async Task<ActionResult<FinancialOperation>> CreateFinancialOperation(FinancialOperation financialOp)
        {
            var createdFinancialOp = await _financialOp.CreateFinancialOperation(financialOp);

            return CreatedAtAction(nameof(GetFinancialOperation), new { id = financialOp.ID }, financialOp);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFinancialOperation(int id, FinancialOperation financialOperation)
        {
            bool success = await _financialOp.UpdateFinancialOperation(id, financialOperation);
            if (!success)
            {
                return BadRequest();
            }
         
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinancialOperation(int id)
        {
            bool success = await _financialOp.DeleteFinancialOperation(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
