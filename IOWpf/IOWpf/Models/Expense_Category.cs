using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    class Expense_Category
    {
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
