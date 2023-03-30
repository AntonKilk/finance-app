using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Models;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly MyFinanceContext _context;

        public ReportController(MyFinanceContext context)
        {
            _context = context;
        }
        [HttpGet("daily")]
        public async Task<ActionResult<Report>> GetDailyReport(DateTime date)
        {
            var report = new Report();

            var income = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date && o.Amount > 0)
                .SumAsync(o => o.Amount);

            var expenses = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date && o.Amount < 0)
                .SumAsync(o => o.Amount);

            var operations = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date)
                .ToListAsync();

            report.Income = income;
            report.Expenses = expenses;
            report.Operations = operations;

            return report;
        }

        [HttpGet("period")]
        public async Task<ActionResult<Report>> GetPeriodReport(DateTime startDate, DateTime endDate)
        {
            var report = new Report();

            var income = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date && o.Amount > 0)
                .SumAsync(o => o.Amount);

            var expenses = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date && o.Amount < 0)
                .SumAsync(o => o.Amount);

            var operations = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date)
                .ToListAsync();

            report.Income = income;
            report.Expenses = expenses;
            report.Operations = operations;

            return report;
        }
    }
}
