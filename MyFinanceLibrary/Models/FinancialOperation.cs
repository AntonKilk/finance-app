
namespace MyFinanceLibrary.Models
{
    public class FinancialOperation
    {
        public int ID { get; set; }
        public int OperationTypeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public bool IsDel { get; set; } = false;
    }
}
