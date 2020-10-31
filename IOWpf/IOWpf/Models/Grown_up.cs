using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Grown_up : User
    {
        public Grown_up() { }

        public Grown_up(string name, string password) : base(name, password) { }

    }
}
