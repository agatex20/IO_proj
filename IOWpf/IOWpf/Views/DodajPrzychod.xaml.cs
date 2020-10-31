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

namespace IOWpf.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DodajPrzychod.xaml
    /// </summary>
    public partial class DodajPrzychod : UserControl
    {
        public DodajPrzychod()
        {
            InitializeComponent();
        }

        private void AddClicked(object sender, RoutedEventArgs e)
        {
            Grown_up adult = new Grown_up("XYZ", "xyz");
            adult.ID = 1;
            float am = float.Parse(amount.Text);

            //adult.add_income(am, date.Text, des.Text);                //zmienic ze nie Grown_up ma ta metode tylko Grown_up_service
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
