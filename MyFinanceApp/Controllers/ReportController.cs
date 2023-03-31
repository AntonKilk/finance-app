using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Models;
using MyFinanceLibrary.Services.Interfaces;

namespace MyFinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("daily")]
        public async Task<ActionResult<Report>> GetDailyReport(DateTime date)
        {
           var report = await _reportService.GetDailyReport(date);

            return report;
        }

        [HttpGet("period")]
        public async Task<ActionResult<Report>> GetPeriodReport(DateTime startDate, DateTime endDate)
        {
            var report = await _reportService.GetPeriodReport(startDate, endDate);

            return report;
        }
    }
}
