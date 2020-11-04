using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Expense_Category
    {
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public void newitem(string cat)
        {
            using (var db = new Application_context())
            {
                var category = db.Categories.First(i => i.Category_name == cat);
                //var expen = db.Expenses.Last(i => i.ExpenseId > 0);
                var expen = db.Expenses.OrderByDescending(p => p.ExpenseId).FirstOrDefault();

                var Exp_Cat = new Expense_Category
                {
                    Expense = expen,
                    Category=category
                };

                db.Expense_Categories.Add(Exp_Cat);
                db.SaveChanges();
            }           
        }
    }
}
