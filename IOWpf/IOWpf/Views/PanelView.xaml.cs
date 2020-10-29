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
    /// Logika interakcji dla klasy PanelView.xaml
    /// </summary>
    public partial class PanelView : UserControl
    {
        public PanelView()
        {
            InitializeComponent();
            using (var db = new Application_context())
            {
                List<Expense> lists = db.Expenses.ToList();
                // ICollection<Expense> expens = lists;
                int number_of_expenses = lists.Count();
                if (number_of_expenses > 6)
                    lists.RemoveRange(0, number_of_expenses - 6);
                 
                    lvDataBinding.ItemsSource = lists;
            }
            
        }
    }
}
