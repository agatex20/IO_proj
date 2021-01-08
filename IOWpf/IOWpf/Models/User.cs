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
    }
}
