
namespace MyFinanceLibrary.Models
{
    public class FinancialOperation
    {
        public int ID { get; set; }
        public int IncomeTypeID { get; set; }
        public int ExpenseTypeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
