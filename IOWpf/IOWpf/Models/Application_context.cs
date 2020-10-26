using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace IOWpf.Models
{
    class Application_context : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Piggy_bank> Piggy_Banks { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Grown_up> Grown_Ups { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");
    }
}
