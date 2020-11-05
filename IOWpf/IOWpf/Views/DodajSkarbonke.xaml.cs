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
using IOWpf.Services;

namespace IOWpf.Views
{
    /// <summary>
    /// Logika interakcji dla klasy DodajSkarbonke.xaml
    /// </summary>
    public partial class DodajSkarbonke : UserControl
    {
        public DodajSkarbonke()
        {
            InitializeComponent();
        }

        private void AddClicked(object sender, RoutedEventArgs e)
        {
            Grown_up_service g_controller = new Grown_up_service();
            float mi = float.Parse(monthly_income.Text);
            float ta = float.Parse(start_amount.Text);
            float ga = float.Parse(goal_amount.Text);
            // Child_service c_controller = new Child_service();
            g_controller.add_piggy_banks(ta, ga, mi, date.Text, pb_name.Text);

            using (var db = new Application_context())
            {
                MainWindow.pblist = db.Piggy_Banks.ToList();
            }
        }
    }
}
