using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Grown_up : User
    {
        public Grown_up(string name, string password) : base(name, password)
        {

        }

        public override void add_expense()
        {
            base.add_expense();
        }

        public override void add_income()
        {
            base.add_income();
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
