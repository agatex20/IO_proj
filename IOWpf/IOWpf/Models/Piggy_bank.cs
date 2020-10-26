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
        public virtual ICollection<User> Users { get; set; }                        // Many Piggy_banks to many Users

        private string creator_name;
        private float goal;
        private string goal_date;
        private string goal_namel;
        private bool if_childs;
        private float monthly_income;
        private int start_day;
        private float treasured_amount;


        public Piggy_bank() 
        {
            this.Users = new HashSet<User>();
        }

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
