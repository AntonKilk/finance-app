using MyFinanceLibrary;
using MyFinanceBlazor.Services.Interfaces;

namespace MyFinanceBlazor.Services
{
    public class ReportService : IReportService
    {
        private readonly MyHttpService _httpService;

        public ReportService(MyHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<Report> GetDailyReport(DateTime date)
        {
            string formattedDate = date.ToString("yyyy-MM-dd");
            string url = $"/Report/daily?date={formattedDate}";
            return await _httpService.GetAsync<Report>(url);
        }

        public async Task<Report> GetPeriodReport(DateTime startDate, DateTime endDate)
        {
            string formattedStartDate = startDate.ToString("yyyy-MM-dd");
            string formattedEndStartDate = endDate.ToString("yyyy-MM-dd");
            string url = $"/Report/period?startDate={formattedStartDate}&endDate={formattedEndStartDate}";
            return await _httpService.GetAsync<Report>(url);
        }
    }
}
