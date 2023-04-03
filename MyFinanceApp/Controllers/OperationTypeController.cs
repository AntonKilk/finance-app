using Microsoft.AspNetCore.Mvc;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationTypeController : ControllerBase
    {
        IOperationTypeService _operationTypeService;

        public OperationTypeController(IOperationTypeService operationTypeService)
        {
            _operationTypeService = operationTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperationType>>> GetOperationTypes()
        {
            return await _operationTypeService.GetOperationTypes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OperationType>> GetOperationType(int id)
        {
            var operationType = await _operationTypeService.GetOperationType(id);

            if (operationType == null)
            {
                return NotFound();
            }

            return operationType;
        }

        [HttpPost]
        public async Task<ActionResult<OperationType>> CreateOperationType(OperationType operationType)
        {
            var createdOperationType = await _operationTypeService.CreateOperationType(operationType);

            return CreatedAtAction(nameof(GetOperationType), new { id = createdOperationType.ID }, createdOperationType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOperationType(int id, OperationType operationType)
        {
            bool success = await _operationTypeService.UpdateOperationType(id, operationType);
            if (!success)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperationType(int id)
        {
            bool success = await _operationTypeService.DeleteOperationType(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
