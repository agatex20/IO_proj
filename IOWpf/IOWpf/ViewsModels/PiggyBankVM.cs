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
    using System.Windows.Input;
    using System.Windows.Controls;
    using System.Diagnostics;

    public class PiggyBankVM : INotifyPropertyChanged
    {
        private PiggyBank pBank = new PiggyBank();
        float amount;
        public float operationAmount
        {
            set
            {
                amount = (float)value;
                onPropertyChanged(nameof(operationAmount));
            }

        }


        private Button _buttonPressed;
        public Button buttonPressed
        {
            get
            {
                return this._buttonPressed;
            }
            set
            {
                this._buttonPressed = value;
                onPropertyChanged(nameof(buttonPressed));
            }
        }

        private ICommand operation;

        public ICommand depositCommand
        { 
            get 
            {
                operation = new RelayCommand(param => this.Deposit(_buttonPressed));
                return operation;
            } 
        
        }

        public ICommand withdrawCommand
        {
            get
            {
                operation = new RelayCommand(param => this.Withdraw(_buttonPressed));
                return operation;
            }

        }

        private void Deposit(object sender)
        {
            pBank.piggyBankId = Int32.Parse((sender as Button).Uid);
            pBank.Deposit(amount);
        }
        private void Withdraw(object sender)
        {
            pBank.piggyBankId = Int32.Parse((sender as Button).Uid);
            pBank.Withdraw(amount);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
