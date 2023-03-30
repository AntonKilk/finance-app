using Microsoft.AspNetCore.Mvc;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeController : ControllerBase
    {
        IIncomeService _incomeService;
        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncomeType>>> GetIncomeTypes()
        {
            return await _incomeService.GetIncomeTypes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IncomeType>> GetIncomeType(int id)
        {
            var incomeType = await _incomeService.GetIncomeType(id);

            if (incomeType == null)
            {
                return NotFound();
            }

            return incomeType;
        }

        [HttpPost]
        public async Task<ActionResult<IncomeType>> CreateIncomeType(IncomeType incomeType)
        {
            var createdIncomeType = await _incomeService.CreateIncomeType(incomeType);

            return CreatedAtAction(nameof(GetIncomeType), new { id = incomeType.ID }, createdIncomeType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIncomeType(int id, IncomeType incomeType)
        {
            bool success = await _incomeService.UpdateIncomeType(id, incomeType);
            if (!success)
            {
                return BadRequest();
            }
           
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomeType(int id)
        {
            bool success = await _incomeService.DeleteIncomeType(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
