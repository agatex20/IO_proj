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
        List<Income> inclist = new List<Income>();
        List<Expense> explist = new List<Expense>();
        public ObservableCollection<Money_flow> list { get; set; }

        public PanelViewModel()
        {
            if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
            {
                foreach (var income in MainWindow.inclist)
                {
                    if (income.UserId == MainWindow.user.ID)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<Money_flow>(inclist);
                onPropertyChanged(nameof(list));
            }
            else
            {
                foreach (var income in MainWindow.inclist)
                {
                    if (income.if_childs == false)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<Money_flow>(inclist);
                onPropertyChanged(nameof(list));
            }
        }

        private ICommand _expenseClicked;
        public ICommand expenseClicked
        {
            get
            {
                if (_expenseClicked == null)
                {
                    _expenseClicked = new RelayCommand(param => this.showExpense());
                }
                return _expenseClicked;
            }
        }

        private void showExpense()
        {
            explist.Clear();

            if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
            {
                foreach (var expense in MainWindow.explist)
                {
                    if (expense.UserId == MainWindow.user.ID)
                        explist.Add(expense);
                }

                this.list = new ObservableCollection<Money_flow>(explist);
                onPropertyChanged(nameof(list));
            }
            else
            {
                foreach (var expense in MainWindow.explist)
                {
                    if (expense.if_childs == false)
                        explist.Add(expense);
                }

                this.list = new ObservableCollection<Money_flow>(explist);
                onPropertyChanged(nameof(list));
            }
        }

        private ICommand _incomeClicked;
        public ICommand incomeClicked
        {
            get
            {
                if (_incomeClicked == null)
                {
                    _incomeClicked = new RelayCommand(param => this.showIncome());
                }
                return _incomeClicked;
            }
        }

        private void showIncome()
        {
            inclist.Clear();

            if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
            {
                foreach (var income in MainWindow.inclist)
                {
                    if (income.UserId == MainWindow.user.ID)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<Money_flow>(inclist);
                onPropertyChanged(nameof(list));
            }
            else
            {            
                foreach (var income in MainWindow.inclist)
                {
                    if (income.if_childs == false)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<Money_flow>(inclist);
                onPropertyChanged(nameof(list));
            }
        }

        public double curr_balance
        {
            get
            {
                return MainWindow.ballist[MainWindow.user.BalanceId - 1].curr_balance;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
