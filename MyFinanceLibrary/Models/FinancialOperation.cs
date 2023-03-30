using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
