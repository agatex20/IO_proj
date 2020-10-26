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

        private float curr_balance;
        private int[] users;


        public Balance() { }

        public Balance(float currBalance, int[] users)
        {
            curr_balance = currBalance;
            this.users = users;
        }

        public float calc_balance()
        {
            return 0.0f;
        }

    }
}
