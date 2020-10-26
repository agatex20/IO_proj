﻿using System;
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


        protected User() { }

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
