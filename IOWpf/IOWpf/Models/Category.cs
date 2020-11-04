using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Category_name { get; set; }
        public virtual ICollection<Expense_Category> Expense_Categories { get; set; }
           
    }
}
