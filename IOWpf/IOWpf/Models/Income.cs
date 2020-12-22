using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace IOWpf.Models
{
    public class Income : Money_flow
    {
        public int IncomeId { get; set; }
        public int? UserId { get; set; }                            // Foreign key 
        public virtual User User { get; set; }                       // Income is associated with one User

        public Income() { }

        public Income(float amount, string creatorName, string date, string description, bool ifChilds) : base(amount, creatorName, date, description, ifChilds) { }

        public override void add()
        {
            using (var db = new Application_context())
            {
                Income inc = new Income();
                inc.amount = amount;
                inc.date = date;
                inc.creator_name = creator_name;
                inc.description = description;
                //exp.UserId = UserId; gdy będzie działać dodawanie userów to włączyć
                inc.if_childs = if_childs;
                
                db.Incomes.Add(inc);

                var balance = db.Balances.SingleOrDefault(b => b.BalanceId == 1);       // poki co dla konta nr 1, jak bedzie podzial na userow to bedzie inaczej
                if (balance != null)
                {
                    balance.curr_balance += inc.amount;
                }

                db.SaveChanges();
                MainWindow.inclist = db.Incomes.ToList();
            }
        }

        public double summing(/*string startDate, string endDate*/)
        {

            var sum = 0.0;

            for (int i = 0; i < MainWindow.inclist.Count; i++)
            {
                //if(DateTime.Parse(MainWindow.inclist[i].date) >= DateTime.Parse(startDate) &&
                //    DateTime.Parse(MainWindow.inclist[i].date) <= DateTime.Parse(endDate))
                //{
                    sum += MainWindow.inclist[i].amount;
                //}
            }

            return sum;
        }
    }
}
