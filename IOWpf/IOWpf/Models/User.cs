using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public abstract class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }                        // one User to many Incomes
        public virtual ICollection<Expense> Expenses { get; set; }                      // one User to many Expenses
        public virtual ICollection<User_Piggy_bank> User_Piggy_banks { get; set; }
        public int BalanceId { get; set; }                                              // foreign key
        public Balance Balance { get; set; }


        protected User() 
        {
            this.Incomes = new HashSet<Income>();                       // ?
            this.Expenses = new HashSet<Expense>();                     // ?
        }

        protected User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        
        public bool LoginPasswordCorrect(String password, String login)
        {
            User user = null;
            using (var db = new Application_context())
            {
                    user = db.Children.FirstOrDefault(i => (i.name == login && i.password == password));
                if (user == null)
                    user = db.Admins.FirstOrDefault(i => (i.name == login && i.password == password));
                if (user == null)
                    user = db.Grown_Ups.FirstOrDefault(i => (i.name == login && i.password == password));
                if(user == null)
                {
                    return false;
                }
                else
                {
                    MainWindow.user = user;
                    return true;
                }
            }
        }

        public virtual void AddToBase(String name, String password, int type) { }

        public bool AdminExists()
        {
            Admin temp = new Admin();
            using (var db = new Application_context())
            {
                temp = db.Admins.FirstOrDefault();
            }
            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
