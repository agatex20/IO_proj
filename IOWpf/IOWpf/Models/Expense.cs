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
           // exp.UserId = UserId; gdy będzie działać dodawanie userów to włączyć
            exp.if_childs=if_childs;
            exp.bill_photo_path = bill_photo_path;
            using (var db = new Application_context())
            {
                db.Expenses.Add(exp);

                var balance = db.Balances.SingleOrDefault(b => b.BalanceId == 1);       // poki co dla konta nr 1, jak bedzie podzial na userow to bedzie inaczej
                if (balance != null)
                {
                    balance.curr_balance -= exp.amount;
                }
                
                db.SaveChanges();
            }
        }
    }
}
