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
    public class DodajSkarbonke : INotifyPropertyChanged
    {

        private Piggy_bank pBank = new Piggy_bank();

        public string name
        {
            set
            {
                pBank.goal_namel = value;
                onPropertyChanged(nameof(name));
            }
        }

        public string date
        {
            set
            {
                pBank.goal_date = value;
                onPropertyChanged(nameof(date));
            }
        }

        public double startAmount
        {
            set
            {
                pBank.treasured_amount = (float)value;
                onPropertyChanged(nameof(startAmount));
            }
        }

        public double targetAmount
        {
            set
            {
                pBank.goal = (float)value;
                onPropertyChanged(nameof(targetAmount));
            }
        }

        public double deposit
        {
            set
            {
                pBank.monthly_income = (float)value;
                onPropertyChanged(nameof(deposit));
            }
        }

        private ICommand _AddPiggyBank;

        public ICommand AddPiggyBank
        {
            get
            {
                pBank.creator_name = MainWindow.user.name;
                if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
                {
                    pBank.if_childs = true;
                }
                else
                {
                    pBank.if_childs = false;
                }
                if(_AddPiggyBank == null)
                {
                    _AddPiggyBank = new RelayCommand(param => this.SaveBank(), param => this.CanSave());
                }
                return _AddPiggyBank;
            }
        }

        private bool CanSave()
        {
            if (pBank.treasured_amount < 0.0 || pBank.goal_date == "")
            {
                return false;
            }
            return true;
        }

        private void SaveBank()
        {
            pBank.add();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
