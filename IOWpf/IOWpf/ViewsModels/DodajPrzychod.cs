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
                Inc.creator_name = MainWindow.user.name;
                if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
                    Inc.if_childs = true;
                else
                    Inc.if_childs = false;
                Inc.UserId = MainWindow.user.ID;

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
            if(Inc.amount==0.0||Inc.date=="")
            {
                return false;
            }
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
