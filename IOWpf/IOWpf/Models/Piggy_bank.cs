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
        public int start_day { get; set; }
        public float treasured_amount { get; set; }


        public Piggy_bank() { }

        public Piggy_bank(string creatorName, float goal, string goalDate, string goalNamel, bool ifChilds, float monthlyIncome, int startDay, float treasuredAmount)
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

        public void deposit()
        {

        }

        public void end_piggy_bank()
        {

        }

        public void withdraw()
        {

        }

    }
}
