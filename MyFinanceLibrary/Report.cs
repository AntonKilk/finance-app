using MyFinanceLibrary.Models;

namespace MyFinanceLibrary
{
    public class Report
    {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public List<FinancialOperation>? Operations { get; set; }
    }
}
