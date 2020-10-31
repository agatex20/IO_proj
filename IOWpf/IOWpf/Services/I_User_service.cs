using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public interface I_User_service
    {
        void add_expense(float _amount, string _date, string _description, string _category);

        void add_income(float _amount, string _date, string _description);

        void add_piggy_banks();

        void check_piggy_banks();

        void check_statistics();

        void edit_account();
    }
}
