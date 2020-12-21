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
    using System.Runtime.InteropServices.WindowsRuntime;

    public class DodajPrzychod : INotifyPropertyChanged
    {
        private Income Inc = new Income();

        public double amount
        {
            set
            {
                Inc.amount = (float)value;
                onPropertyChanged(nameof(amount));
            }
            
        }
        public string date
        {
            set
            {
                Inc.date = value;
                onPropertyChanged(nameof(date));
            }
        }

        public string description
        {
            set
            {
                Inc.description = value;
                onPropertyChanged(nameof(description));
            }
        }


        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                Inc.creator_name = MainWindow.curr_name;
                if (MainWindow.curr_type == 3)
                    Inc.if_childs = true;
                else
                    Inc.if_childs = false;
                Inc.UserId = MainWindow.curr_id;

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

        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
