using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
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
    /// Logika interakcji dla klasy DodajWydatek.xaml
    /// </summary>
    public partial class DodajWydatek : UserControl
    {
        public DodajWydatek()
        {
            InitializeComponent();
            cat.ItemsSource = MainWindow.catlist;
        }
        
        private void Data(object sender, TextCompositionEventArgs e)
        {

        }
        
        private void AddClicked(object sender, RoutedEventArgs e)
        {
            Grown_up_service g_controller = new Grown_up_service();
            Child_service c_controller = new Child_service();

            

            float am = float.Parse(amount.Text);
            if (Login.type==3)
            {
                foreach (var item in cat.SelectedItems)
                {
                    c_controller.catlist.Add(item.ToString());
                }
                c_controller.add_expense(am, date.Text, des.Text, Login.id, Login.name, path.Text);    
            }
            else
            {
                foreach (var item in cat.SelectedItems)
                {
                    g_controller.catlist.Add(item.ToString()) ;
                }
                g_controller.add_expense(am, date.Text, des.Text, Login.id, Login.name, path.Text);            
            }

            using (var db = new Application_context())
            {
                MainWindow.explist = db.Expenses.ToList();
            }
        }

        private void OpenFileClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                path.Text = openFileDialog.FileName;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

    }
}
