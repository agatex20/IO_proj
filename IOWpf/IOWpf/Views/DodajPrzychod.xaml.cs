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
    /// Logika interakcji dla klasy DodajPrzychod.xaml
    /// </summary>
    public partial class DodajPrzychod : UserControl
    {
        public DodajPrzychod()
        {
            InitializeComponent();
        }
        /*
        private void AddClicked(object sender, RoutedEventArgs e)
        {
            Grown_up_service g_controller = new Grown_up_service();
            Child_service c_controller = new Child_service();

            float am = float.Parse(amount.Text);
            if (Login.type == 3)
            {
                c_controller.add_income(am, date.Text, des.Text, Login.id, Login.name);
            }
            else
            {
                g_controller.add_income(am, date.Text, des.Text, Login.id, Login.name);
            }

            using (var db = new Application_context())
            {
                MainWindow.inclist = db.Incomes.ToList();
            }
        }*/

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
