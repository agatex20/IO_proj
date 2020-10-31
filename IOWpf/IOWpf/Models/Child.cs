using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Child : User
    {
        public Child() { }

        public Child(string name, string password) : base(name, password) { }

    }
}
