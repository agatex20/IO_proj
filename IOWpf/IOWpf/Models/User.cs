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
        protected string name { get; set; }
        protected string password { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }                        // one User to many Incomes
        public virtual ICollection<Expense> Expenses { get; set; }                      // one User to many Expenses
        public virtual ICollection<User_Piggy_bank> User_Piggy_banks { get; set; }
        public int BalanceId { get; set; }                                              // forein key
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

        public virtual void add_expense()
        {

        }

        public virtual void add_income()
        {

        }

        public virtual void add_piggy_banks()
        {

        }

        public virtual void check_statistics()
        {

        }

        public virtual void edit_account()
        {

        }


    }
}
