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
             db.SaveChanges();
             MainWindow.inclist = db.Incomes.ToList();
            }
        }
    }
}
