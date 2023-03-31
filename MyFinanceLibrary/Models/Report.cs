
namespace MyFinanceLibrary.Models
{
    public class Report
    {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public List<FinancialOperation>? Operations { get; set; }
    }
}
