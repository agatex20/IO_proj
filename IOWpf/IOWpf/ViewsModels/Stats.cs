using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IOWpf.ViewsModels 
{
    using Views;
    using Models;
    using Commands;
    public class Stats : INotifyPropertyChanged
    {
        private Expense exp = new Expense();
        private Income inc = new Income();


        public string incomes
        {
            get
            {
                return inc.summing() + " zł";
            }

        }
        public string expences
        {
            get
            {
                return exp.summing() + " zł";
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
