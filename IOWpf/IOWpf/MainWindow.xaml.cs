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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PanelViewClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new PanelView();

            using (var db = new Application_context())
            {
                // ------------- Create --------------- //
                //Balance newBalance = new Balance(10.0);
                //db.Balances.Add(newBalance);
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
    }
       
}
