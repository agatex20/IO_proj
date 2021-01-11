using System.ComponentModel;

namespace IOWpf.ViewsModels
{
    using Models;
    using LiveCharts;

    public class Stats : INotifyPropertyChanged
    {
        private Expense exp = new Expense();
        private Income inc = new Income();
        private Category category = new Category();

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

        public ChartValues<double> categoriesValues 
        { 
            get
            {
                return new ChartValues<double>(exp.categorySum());
            }
        }

        public ChartValues<string> categoriesNames 
        {
            get
            {
                return new ChartValues<string>(category.getList());
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
