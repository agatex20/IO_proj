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

            //if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
            //{
            //    List<Income> inclistChild = new List<Income>();

            //    foreach (var income in MainWindow.inclist)
            //    {
            //        if (income.UserId == MainWindow.user.ID)
            //            inclistChild.Add(income);
            //    }

            //    lvDataBinding.ItemsSource = inclistChild;
            //}
            //else
            //{
            //    List<Income> inclistChild = new List<Income>();

            //    foreach (var income in MainWindow.inclist)
            //    {
            //        if (income.if_childs == false)
            //            inclistChild.Add(income);
            //    }

            //    lvDataBinding.ItemsSource = inclistChild;
            //}
        }

        //private void ExpensesClicked(object sender, RoutedEventArgs e)
        //{
        //    if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
        //    {
        //        List<Expense> explistChild = new List<Expense>();

        //        foreach (var expense in MainWindow.explist)
        //        {
        //            if (expense.UserId == MainWindow.user.ID)
        //                explistChild.Add(expense);
        //        }

        //        lvDataBinding.ItemsSource = explistChild;
        //    }
        //    else
        //    {
        //        List<Expense> explistAdult = new List<Expense>();

        //        foreach (var expense in MainWindow.explist)
        //        {
        //            if (expense.if_childs == false)
        //                explistAdult.Add(expense);
        //        }

        //        lvDataBinding.ItemsSource = explistAdult;
        //    }
        //}

        //private void IncomesClicked(object sender, RoutedEventArgs e)
        //{
        //    if (MainWindow.user.GetType().ToString() == "IOWpf.Models.Child")
        //    {
        //        List<Income> inclistChild = new List<Income>();

        //        foreach (var income in MainWindow.inclist)
        //        {
        //            if (income.UserId == MainWindow.user.ID)
        //                inclistChild.Add(income);
        //        }

        //        lvDataBinding.ItemsSource = inclistChild;
        //    }
        //    else
        //    {
        //        List<Income> inclistChild = new List<Income>();

        //        foreach (var income in MainWindow.inclist)
        //        {
        //            if (income.if_childs == false)
        //                inclistChild.Add(income);
        //        }

        //        lvDataBinding.ItemsSource = inclistChild;
        //    }
        //}

    }
}
