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
    using System.Diagnostics;
    using System.IO;

    public class PanelViewModel : INotifyPropertyChanged
    {
        List<Income> inclist = new List<Income>();
        List<Expense> explist = new List<Expense>();
        public ObservableCollection<MoneyFlow> list { get; set; }

        public PanelViewModel()
        {
            showExpense();              // tymczasowo zeby explist byla wypelniona zeby nie wywalalo sie na otwieraniu zdjecia
            showIncome();
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
                foreach (var expense in MainWindow.expensesList)
                {
                    if (expense.userId == MainWindow.user.ID)
                        explist.Add(expense);
                }

                this.list = new ObservableCollection<MoneyFlow>(explist);
                onPropertyChanged(nameof(list));
            }
            else
            {
                foreach (var expense in MainWindow.expensesList)
                {
                    if (expense.ifChilds == false)
                        explist.Add(expense);
                }

                this.list = new ObservableCollection<MoneyFlow>(explist);
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
                foreach (var income in MainWindow.incomesList)
                {
                    if (income.userId == MainWindow.user.ID)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<MoneyFlow>(inclist);
                onPropertyChanged(nameof(list));
            }
            else
            {            
                foreach (var income in MainWindow.incomesList)
                {
                    if (income.ifChilds == false)
                        inclist.Add(income);
                }

                this.list = new ObservableCollection<MoneyFlow>(inclist);
                onPropertyChanged(nameof(list));
            }
        }

        private ICommand _showPhotoClicked;
        public ICommand showPhotoClicked
        {
            get
            {
                if (_showPhotoClicked == null)
                {
                    _showPhotoClicked = new RelayCommand(param => this.showPhoto());
                }
                return _showPhotoClicked;
            }
        }

        private void showPhoto()
        {
            //string picturePath = explist[/* odpowiedni rzad + 1 */].bill_photo_path;
            string picturePath = "D:\\Pictures\\Wallpapers\\campfire.jpg";

            if (!String.IsNullOrEmpty(picturePath) && File.Exists(picturePath))
            {
                ProcessStartInfo info = new ProcessStartInfo();

                info.FileName = Path.Combine("ms-photos://", picturePath);
                info.UseShellExecute = true;
                info.CreateNoWindow = true;
                info.Verb = string.Empty;

                Process.Start(info);
            }
        }

        public double curr_balance
        {
            get
            {
                return MainWindow.ballancesLst[MainWindow.user.balanceId - 1].currentBalance;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
