using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Piggy_bank
    {
        public int Piggy_bankId { get; set; }
        public virtual ICollection<User_Piggy_bank> User_Piggy_banks { get; set; }

        public string creator_name { get; set; }
        public float goal { get; set; }
        public string goal_date { get; set; }
        public string goal_namel { get; set; }
        public bool if_childs { get; set; }
        public float monthly_income { get; set; }
        public string start_day { get; set; }
        public float treasured_amount { get; set; }


        public Piggy_bank() { }

        public Piggy_bank(string creatorName, float goal, string goalDate, string goalNamel, bool ifChilds, float monthlyIncome, string startDay, float treasuredAmount)
        {
            creator_name = creatorName;
            this.goal = goal;
            goal_date = goalDate;
            goal_namel = goalNamel;
            if_childs = ifChilds;
            monthly_income = monthlyIncome;
            start_day = startDay;
            treasured_amount = treasuredAmount;
        }

        public void add()
        {
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            orderby pb.Piggy_bankId descending
                            select pb;
                int next_id = query.FirstOrDefault().Piggy_bankId + 1;

                Piggy_bank pBank = new Piggy_bank();
                pBank.Piggy_bankId = next_id;
                pBank.treasured_amount = treasured_amount;
                pBank.goal = goal;
                pBank.goal_namel = goal_namel;
                if (MainWindow.curr_type == 3)
                {
                    pBank.if_childs = true;
                }
                else
                {
                    pBank.if_childs = false;
                }
                pBank.monthly_income = monthly_income;
                pBank.start_day = MainWindow.curr_day;
                pBank.creator_name = MainWindow.user.name;
                pBank.goal_date = goal_date;

                db.Piggy_Banks.Add(pBank);
                db.SaveChanges();
                MainWindow.pblist = db.Piggy_Banks.ToList();

            }
        }

        public void deposit(float _amount)
        {
            int PbId = this.Piggy_bankId;
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

        public void delete()
        {
            int PbId = this.Piggy_bankId;
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            where pb.Piggy_bankId == PbId
                            select pb;
                if (query.Any())
                {
                    db.Piggy_Banks.Remove(query.FirstOrDefault());
                }
                query = from pb in db.Piggy_Banks
                        select pb;
                
                db.SaveChanges();
                MainWindow.pblist.Clear();
                MainWindow.pblist = db.Piggy_Banks.ToList();

            }
        }

        public void withdraw(float _amount)
        {
            int PbId = this.Piggy_bankId;
            using (var db = new Application_context())
            {
                var query = from pb in db.Piggy_Banks
                            where pb.Piggy_bankId == PbId
                            select pb;
                query.FirstOrDefault().treasured_amount -= _amount;
                if (query.FirstOrDefault().treasured_amount < 0)
                {
                    query.FirstOrDefault().treasured_amount += _amount;
                }
                db.SaveChanges();
                MainWindow.pblist.Clear();
                MainWindow.pblist = db.Piggy_Banks.ToList();
            }
        }
    }
}
