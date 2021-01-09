using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Child : User
    {
        public Child() { }

        public Child(string name, string password) : base(name, password) { }

        public void newBalanceId()
        {
            var temp = new Balance();
            using(var db = new Application_context())
            {
                db.Balances.Add(temp);
                temp = db.Balances.OrderByDescending(p => p.BalanceId).FirstOrDefault();
                db.SaveChanges();
            }
            this.BalanceId = temp.BalanceId+1;
        }
    }
}
