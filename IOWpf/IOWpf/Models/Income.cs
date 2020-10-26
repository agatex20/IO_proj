using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    class Income : Money_flow
    {
        public Income(float amount, string creatorName, string date, string description, bool ifChilds) : base(amount, creatorName, date, description, ifChilds)
        {
        }

        public override void edit()
        {
            base.edit();
        }

        public override bool get_direction()
        {
            return base.get_direction();
        }
    }
}
