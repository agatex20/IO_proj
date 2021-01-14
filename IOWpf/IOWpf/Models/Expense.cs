using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace IOWpf.Models
{
    public class Expense : Money_flow
    {
        public int ExpenseId { get; set; }
        public string bill_photo_path { get; set; }

        public int? UserId { get; set; }                             // Foreign key 
        public virtual User User { get; set; }                       // Expense is associated with one User
        public virtual ICollection<Expense_Category> Expense_Categories { get; set; }
        

        public Expense() { }

     
        public Expense(float amount, string creatorName, string date, string description, bool ifChilds, string bill_photo_path) : base(amount, creatorName, date, description, ifChilds)
        {
            this.bill_photo_path = bill_photo_path;
        }

        public override void add()
        {
            Expense exp = new Expense();
            exp.amount = amount;
            exp.date=date;
            exp.creator_name=creator_name;
            exp.description=description;
            exp.UserId = UserId;
            exp.if_childs=if_childs;
            exp.bill_photo_path = bill_photo_path;
            using (var db = new Application_context())
            {
                db.Expenses.Add(exp);

                var balance = db.Balances.SingleOrDefault(b => b.BalanceId == MainWindow.user.BalanceId);       
                if (balance != null)
                {
                    balance.curr_balance -= exp.amount;
                }
                
                db.SaveChanges();
                MainWindow.explist = db.Expenses.ToList();
                MainWindow.ballist = db.Balances.ToList();
            }
        }

        public double summing(/*string startDate, string endDate*/)
        {

            var sum = 0.0;

            for (int i = 0; i < MainWindow.explist.Count; i++)
            {

                //if (DateTime.Parse(MainWindow.explist[i].date) >= DateTime.Parse(startDate) &&
                //    DateTime.Parse(MainWindow.explist[i].date) <= DateTime.Parse(endDate))
                //{
                //    sum += MainWindow.explist[i].amount;
                //}

                if (MainWindow.explist[i].UserId == MainWindow.curr_id)
                {
                    sum += MainWindow.explist[i].amount;
                }
            }

            return sum;
        }

        public List<double> categorySum()
        {
            List<double> returning = new List<double>();

            for (int i = 1; i < 8; i++)
            {
                var sum = 0.0;

                for (int j = 0; j < MainWindow.expense_categories_list.Count; j++)
                {
                    if (MainWindow.expense_categories_list[j].CategoryId == i)
                    {
                        int k = 0;
                        while (MainWindow.explist[k].ExpenseId != MainWindow.expense_categories_list[j].ExpenseId)
                        {
                            k++;
                        }
                        if (MainWindow.explist[k].ExpenseId == MainWindow.expense_categories_list[j].ExpenseId && 
                            MainWindow.explist[k].UserId == MainWindow.curr_id)
                        {
                            sum += MainWindow.explist[k].amount;
                        }
                    }
                }

                returning.Add(sum);
            }

            return returning;
        }

    }   
}

