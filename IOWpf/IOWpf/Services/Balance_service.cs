using IOWpf.Migrations;
using IOWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public class Balance_service
    {
        //public void calc_balance()
        //{
        //    float expsum = 0;
        //    using (var db = new Application_context())
        //    {

        //        List<Expense> explist = db.Expenses.ToList();
        //        List<Income> inclist = db.Incomes.ToList();
        //        inclist = db.Incomes.ToList();
        //        foreach (Expense x in explist)
        //        {
        //            expsum -= x.amount;
        //        }
        //        foreach (Income x in inclist)
        //        {
        //            expsum += x.amount;
        //        }
        //        var query = from b in db.Balances
        //                    select b;
        //        Balance bal = new Balance(expsum);
        //        db.Balances.Add(bal);
        //        db.SaveChanges();

        //    }
        //}
    }
}