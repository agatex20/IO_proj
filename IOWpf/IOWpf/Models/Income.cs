using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Income : Money_flow
    {
        public int IncomeId { get; set; }
        public int? UserId { get; set; }                            // Foreign key 
        public virtual User User{ get; set; }                       // Income is associated with one User

        public Income() { }

        public Income(float amount, string creatorName, string date, string description, bool ifChilds) : base(amount, creatorName, date, description, ifChilds) { }

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
