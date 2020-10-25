using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Classes
{
    public class Balance
    {

        private float curr_balance;
        private string users;

        public Balance(float currBalance, string users)
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
