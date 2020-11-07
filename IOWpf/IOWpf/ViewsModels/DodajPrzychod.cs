using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace IOWpf.ViewsModels
{
    using Models;
    using Commands;
    public class DodajPrzychod : INotifyPropertyChanged
    {
        private Income Inc = new Income();

        public double amount
        {
            set
            {
                Inc.amount = (float)value;
            }
        }

        public string date
        {
            set
            {
                Inc.date = value;
            }
        }

        public string description
        {
            set
            {
                Inc.description = value;
            }
        }

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(param => this.SaveObject(),param => this.CanSave()
                    );
                }
                return _saveCommand;
            }
        }

        private bool CanSave()
        {
            return true;
        }

        private void SaveObject()
        {
            Inc.add();
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
