using IOWpf.Services;
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
using System.Windows.Shapes;

namespace IOWpf.Views
{
    /// <summary>
    /// Logika interakcji dla klasy WybierzKwote.xaml
    /// </summary>
    public partial class WybierzKwote : Window
    {
        private int ElementId;
        private bool IsDeposit;
        public WybierzKwote(int id, bool op)
        {
            InitializeComponent();
            ElementId = id;
            IsDeposit = op;
        }

        public void ConfirmAmount(object sender, RoutedEventArgs e)
        {
            Piggy_bank_service pbs = new Piggy_bank_service();
            if(IsDeposit)
            {
                pbs.deposit(float.Parse(amount.Text), ElementId);
            }
            else
            {
                pbs.withdraw(float.Parse(amount.Text), ElementId);
            }
            this.Close();
        }
    }
}
