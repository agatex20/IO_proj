﻿using IOWpf.Migrations;
using IOWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public class Grown_up_service : I_User_service
    {
        public List<string> catlist = new List<string> { };
        

        public void add_piggy_banks(float _inamount, float _goal, float _montlyincome, string _goaldate, string _goalname)
        {
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            select pb;
                int next_id = query.Count() + 1;

                Piggy_bank pBank = new Piggy_bank();
                pBank.Piggy_bankId = next_id;
                pBank.treasured_amount = _inamount;
                pBank.goal = _goal;
                pBank.goal_namel = _goalname;
                pBank.if_childs = false; //temp
                pBank.monthly_income = _montlyincome;
                pBank.start_day = 0; //temp
                pBank.creator_name = "Seba"; //temp
                pBank.goal_date = _goaldate;

                db.Piggy_Banks.Add(pBank);
                db.SaveChanges();

            }
        }
        public void check_piggy_banks()
        {

        }

        public void check_statistics()
        {

        }

        public void edit_account()
        {

        }
    }
}
