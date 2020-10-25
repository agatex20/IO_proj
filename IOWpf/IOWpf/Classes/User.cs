using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Classes
{
    public abstract class User
    {

        protected string name;
        protected string password;

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
