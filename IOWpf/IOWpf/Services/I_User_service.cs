using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public interface I_User_service
    {
        
 

        void add_piggy_banks(float _inamount, float _goal, float _montlyincome, string _goaldate, string _goalname);

        void check_piggy_banks();

        void check_statistics();

        void edit_account();
    }
}
