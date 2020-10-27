using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Balance
    {
        public int BalanceId { get; set; }
        public ICollection<User> User { get; set; }

        public double curr_balance { get; set; }


        public Balance() { }

        public Balance(double currBalance)
        {
            curr_balance = currBalance;
        }

        public float calc_balance()
        {
            return 0.0f;
        }

    }
}
