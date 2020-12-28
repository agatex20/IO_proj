using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using IOWpf.Models;
using IOWpf.Views;

namespace IOWpf
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Expense> explist;
        public static List<Income> inclist;
        public static List<Piggy_bank> pblist;
        public static List<Balance> ballist;
        public static List<Expense_Category> expense_categories_list;

        public static int curr_id;
        public static string curr_name;
        public static int curr_type;//1-admin, 2- dorosły, 3-dziecko
    public MainWindow()
        {
            InitializeComponent();
            using (var db = new Application_context())
            {
                explist = db.Expenses.ToList();
            }
            using (var db = new Application_context())
            {
                inclist = db.Incomes.ToList();
            }
            using (var db = new Application_context())
            {
                pblist = db.Piggy_Banks.ToList();
            }
            using (var db = new Application_context())
            {
                ballist = db.Balances.ToList();
            }
            using (var db = new Application_context())
            {
                expense_categories_list = db.Expense_Categories.ToList();
            }

        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void  PanelViewClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new PanelView();

            using (var db = new Application_context())
            {
                // ------------- Create --------------- //
                //Balance newBalance = new Balance(1200.0);
                //db.Balances.Add(newBalance);
                //db.SaveChanges();
                /*
                Grown_up adult = new Grown_up();
                adult.name = "Tomek";
                adult.password = "qwerty12345";
                adult.BalanceId = 1;
                db.Grown_Ups.Add(adult);
                db.SaveChanges();
                */
                //Income newIncome = new Income();
                //newIncome.amount = 1000;
                //db.Incomes.Add(newIncome);
                //db.SaveChanges();

                // -------------- Read ---------------- //
                //List<Balance> lists = db.Balances.ToList();
                //ICollection<Balance> balans = lists;

                // ------------- Update ---------------- //
                //Balance firstBalance = db.Balances.FirstOrDefault();
                //firstBalance.curr_balance = 1337.00;
                //db.SaveChanges();

                // -------------- Delete ---------------- //
                //Balance firstBalance = db.Balances.FirstOrDefault();
                //db.Balances.Remove(firstBalance);
                //db.SaveChanges();
            }

        }

        private void DodajWydatekClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DodajWydatek();
        }

        private void DodajPrzychodClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DodajPrzychod();
        }

        public void SkarbonkaClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Skarbonka();
        }

        private void StatystykiClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Stats();
        }

        public void DodajSkarbonkeClicked(object sender, RoutedEventArgs e)
        {
           DataContext = new DodajSkarbonke();
        }

        public void LoginClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Login();
        }
    }
       
}
