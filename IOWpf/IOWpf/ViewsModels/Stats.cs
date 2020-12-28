using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IOWpf.ViewsModels 
{
    using Views;
    using Models;
    using Commands;
    using LiveCharts;

    public class Stats : INotifyPropertyChanged
    {
        private Expense exp = new Expense();
        private Income inc = new Income();

       //private string _startDate;
       //private string _endDate;


       // public string startDate
       // {
       //     get { return _startDate; }
       //     set
       //     {
       //         onPropertyChanged(nameof(startDate));
       //     }
       // }

       // public string endDate
       // {
       //     get { return _endDate; }
       //     set
       //     {
       //         onPropertyChanged(nameof(endDate));
       //     }
       // }


        public string incomes
        {
            get
            {
                return inc.summing(/*startDate, endDate*/) + " zł";
            }

        }
        public string expences
        {
            get
            {
                return exp.summing(/*startDate, endDate*/) + " zł";
            }

        }

        public IChartValues home
        {
            get
            {
                return exp.categorySum(1);
            }

        }
        public IChartValues food
        {
            get
            {
                return exp.categorySum(2);
            }

        }
        public IChartValues car
        {
            get
            {
                return exp.categorySum(3);
            }

        }
        public IChartValues fun
        {
            get
            {
                return exp.categorySum(4);
            }

        }
        public IChartValues clothing
        {
            get
            {
                return exp.categorySum(5);
            }

        }
        public IChartValues education
        {
            get
            {
                return exp.categorySum(6);
            }

        }
        public IChartValues health
        {
            get
            {
                return exp.categorySum(7);
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
