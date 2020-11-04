using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public abstract class Money_flow
    {
        public float amount { get; set; }
        public string creator_name { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public bool if_childs { get; set; }


        protected Money_flow() { }

        protected Money_flow(float amount, string creatorName, string date, string description, bool ifChilds)
        {
            this.amount = amount;
            creator_name = creatorName;
            this.date = date;
            this.description = description;
            if_childs = ifChilds;
        }

        public virtual void add()
        {
        }
    }
}
