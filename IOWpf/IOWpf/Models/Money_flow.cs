using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public abstract class Money_flow
    {
        protected float amount { get; set; }
        private string creator_name { get; set; }
        protected string date { get; set; }
        protected string description { get; set; }
        private bool if_childs { get; set; }


        protected Money_flow() { }

        protected Money_flow(float amount, string creatorName, string date, string description, bool ifChilds)
        {
            this.amount = amount;
            creator_name = creatorName;
            this.date = date;
            this.description = description;
            if_childs = ifChilds;
        }

        public virtual void cancel()
        {

        }

        public virtual void edit()
        {

        }

        public virtual bool get_direction()
        {
            return false;
        }

        public virtual void set_cyclic()
        {

        }



    }
}
