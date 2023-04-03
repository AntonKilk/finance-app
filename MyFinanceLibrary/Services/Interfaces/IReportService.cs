namespace MyFinanceLibrary.Services.Interfaces
{
    public interface IReportService
    {
        Task<Report> GetDailyReport(DateTime date);
        Task<Report> GetPeriodReport(DateTime startDate, DateTime endDate);
    }
}
