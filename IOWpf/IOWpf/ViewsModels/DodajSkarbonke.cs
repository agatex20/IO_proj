using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.ViewsModels
{
    using Views;
    using Models;
    using Commands;
    public class DodajSkarbonke : INotifyPropertyChanged
    {




        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
