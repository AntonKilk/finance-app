using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceLibrary.Models
{
    public class Report
    {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public List<FinancialOperation>? Operations { get; set; }
    }
}
