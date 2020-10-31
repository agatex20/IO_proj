using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Services
{
    public interface I_Money_flow_service
    {
        void cancel();

        void edit();

        bool get_direction();

        void set_cyclic();
    }
}
