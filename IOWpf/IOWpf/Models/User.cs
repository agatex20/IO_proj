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
        protected string name;
        protected string password;

        public virtual ICollection<Income> Incomes { get; set; }                        // one User to many Incomes
        public virtual ICollection<Expense> Expenses { get; set; }                      // one User to many Expenses
        public virtual ICollection<Piggy_bank> Piggy_Banks { get; set; }                // many Users to many Piggy_banks
        public int BalanceId { get; set; }                                              // forein key
        public Balance Balance { get; set; }


        protected User() 
        {
            this.Incomes = new HashSet<Income>();                       // ?
            this.Expenses = new HashSet<Expense>();                     // ?
            this.Piggy_Banks = new HashSet<Piggy_bank>();
        }

        protected User(string name, string password)
        {
            this.Piggy_Banks = new HashSet<Piggy_bank>();

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
