using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Admin : Grown_up
    {
        public Admin() { }

        public Admin(string name, string password) : base(name, password) { }

    }
}
