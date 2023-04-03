using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Data;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceLibrary.Services
{
    public class ReportService : IReportService
    {
        MyFinanceContext _context;
        public ReportService(MyFinanceContext context)
        {
            _context = context;
        }
        public async Task<Report> GetDailyReport(DateTime date)
        {
            var report = new Report();

            var income = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date && o.Amount > 0 && o.IsDel == false)
                .SumAsync(o => o.Amount);

            var expenses = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date && o.Amount < 0 && o.IsDel == false)
                .SumAsync(o => o.Amount);

            var operations = await _context.FinancialOperations
                .Where(o => o.Date.Date == date.Date && o.IsDel == false)
                .ToListAsync();

            report.Income = income;
            report.Expenses = expenses;
            report.Operations = operations;

            return report;
        }

        public async Task<Report> GetPeriodReport(DateTime startDate, DateTime endDate)
        {
            var report = new Report();

            var income = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date && o.Amount > 0 && o.IsDel == false)
                .SumAsync(o => o.Amount);

            var expenses = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date && o.Amount < 0 && o.IsDel == false)
                .SumAsync(o => o.Amount);

            var operations = await _context.FinancialOperations
                .Where(o => o.Date.Date >= startDate.Date && o.Date.Date <= endDate.Date && o.IsDel == false)
                .ToListAsync();

            report.Income = income;
            report.Expenses = expenses;
            report.Operations = operations;

            return report;
        }
    }
}
