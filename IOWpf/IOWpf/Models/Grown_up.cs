using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Grown_up : User
    {
        public Grown_up() { }

        public Grown_up(string name, string password) : base(name, password) { }

        public override void add_expense(float _amount, string _date, string _description, string _category)
        {
            using (var db = new Application_context())
            {

                Expense exp = new Expense();
                exp.amount = _amount;
                exp.date = _date;
                exp.description = _description;
                exp.category = _category;
                exp.creator_name = this.name;
                exp.UserId = this.ID;
                exp.if_childs = false;
                
                db.Expenses.Add(exp);
                db.SaveChanges();
                
            }
        }

        public override void add_income(float _amount, string _date, string _description)
        {
            using (var db = new Application_context())
            {

                Income inc = new Income();
                inc.amount = _amount;
                inc.date = _date;
                inc.description = _description;
                inc.creator_name = this.name;
                inc.UserId = this.ID;
                inc.if_childs = false;

                db.Incomes.Add(inc);
                db.SaveChanges();

            }
        }

        public override void add_piggy_banks()
        {
            base.add_piggy_banks();
        }

        public override void check_statistics()
        {
            base.check_statistics();
        }

        public override void edit_account()
        {
            base.edit_account();
        }

       
    }
}
