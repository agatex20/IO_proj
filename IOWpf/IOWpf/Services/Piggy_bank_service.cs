using IOWpf.Migrations;
using IOWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public class Piggy_bank_service
    {
        public void deposit(float _amount, int PbId)
        {
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            where pb.Piggy_bankId == PbId
                            select pb;
                query.FirstOrDefault().treasured_amount += _amount;
                db.SaveChanges();
                MainWindow.pblist.Clear();
                MainWindow.pblist = db.Piggy_Banks.ToList();
            }
        }

        void end_piggy_bank()
        {

        }

        public void withdraw(float _amount, int PbId)
        {
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            where pb.Piggy_bankId == PbId
                            select pb;
                query.FirstOrDefault().treasured_amount -= _amount;
                db.SaveChanges();
                MainWindow.pblist.Clear();
                MainWindow.pblist = db.Piggy_Banks.ToList();
            }
        }
    }
}
