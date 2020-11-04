using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public interface I_User_service
    {
        
        void add_expense(float _amount, string _date, string _description, int _creator_id, string _creator_name, string bill_path);

        void add_income(float _amount, string _date, string _description, int _creator_id, string _creator_name);

        void add_piggy_banks(float _inamount, float _goal, float _montlyincome, string _goaldate, string _goalname);

        void check_piggy_banks();

        void check_statistics();

        void edit_account();
    }
}
