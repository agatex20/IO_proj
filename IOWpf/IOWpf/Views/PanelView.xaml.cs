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
using IOWpf.Services;
using IOWpf.Views;

namespace IOWpf.Views
{

    /// <summary>
    /// Logika interakcji dla klasy PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        public static bool which = false;
        public PanelView()
        {
            InitializeComponent();
            if(which)
                lvDataBinding.ItemsSource = MainWindow.inclist;
            else
                lvDataBinding.ItemsSource = MainWindow.explist;

            //Balance_service bs = new Balance_service();
            //bs.calc_balance();
        }
        /*
        private void ExpensesClicked(object sender, RoutedEventArgs e)
        {
            lvDataBinding.ItemsSource = MainWindow.explist;
        }

        private void IncomesClicked(object sender, RoutedEventArgs e)
        {
            lvDataBinding.ItemsSource = MainWindow.inclist;
        }
        */
    }
}
