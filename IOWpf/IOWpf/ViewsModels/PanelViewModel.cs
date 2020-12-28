using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IOWpf.ViewsModels
{
    using Views;
    using Models;
    using Commands;
    using System.Collections.ObjectModel;

    public class PanelViewModel : INotifyPropertyChanged
    {
        private ICommand _expenses;
        public ICommand expenses
        {
            get
            {
                if (_expenses == null)
                {
                    _expenses = new RelayCommand(param => this.load_exp(), param => this.can_load_exp());
                }
                return _expenses;
            }
        }

        private void load_exp()
        {
            PanelView.which = false;
        }

        private bool can_load_exp()
        {
            return true;
        }

        private ICommand _incomes;
        public ICommand incomes
        {
            get
            {
                if (_incomes == null)
                {
                    _incomes = new RelayCommand(param => this.load_inc(), param => this.can_load_inc());
                }
                return _incomes;
            }
        }

        private void load_inc()
        {
            PanelView.which = true;
        }
        private bool can_load_inc()
        {
            return true;
        }
        public double curr_balance
        {
            get
            {
                return MainWindow.ballist[0].curr_balance;                  // poki co balans[0] bo nie rozrozniamy userow
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
