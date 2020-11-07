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
using IOWpf;

namespace IOWpf.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Skarbonka.xaml
    /// </summary>
    public partial class Skarbonka : UserControl
    {
        public Skarbonka()
        {
            InitializeComponent();
            lvDataBinding.ItemsSource = MainWindow.pblist;
        }

        private void AddBankClicked(object sender, RoutedEventArgs e)
        {
            MainWindow mw = Window.GetWindow(this) as MainWindow;
            mw.DodajSkarbonkeClicked(sender, e);
            lvDataBinding.ItemsSource = MainWindow.pblist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Deposit(object sender, RoutedEventArgs e)
        {
            int id = (int)(((sender as Button).TransformToAncestor(lvDataBinding).Transform(new Point(0, 0)).Y)/49);
            
            WybierzKwote wk = new WybierzKwote(id, true);
            wk.Show();

        }

        private void Payout(object sender, RoutedEventArgs e)
        {
            int id = (int)(((sender as Button).TransformToAncestor(lvDataBinding).Transform(new Point(0, 0)).Y) / 49);
            
            WybierzKwote wk = new WybierzKwote(id, false);
            wk.Show();
            
            DataContext = new Skarbonka();

        }
    }
}
