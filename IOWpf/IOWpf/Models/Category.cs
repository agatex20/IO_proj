using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Category_name { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }

    }
}
