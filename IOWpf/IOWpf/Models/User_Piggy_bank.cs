using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class User_Piggy_bank
    {
        public int UserId { get; set; }
        public User User { get; set; }


        public int Piggy_bankId { get; set; }
        public Piggy_bank Piggy_bank { get; set; }
    }
}
