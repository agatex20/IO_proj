using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace IOWpf.ViewsModels
{
    using Views;
    using Models;
    using Commands;

    public class DodajWydatek : INotifyPropertyChanged
    {
        private Expense exp = new Expense();
        private Expense_Category exp_cat = new Expense_Category();
        private List<String> selected_categories = new List<string>();
        public double amount
        {
            set
            {
                exp.amount = (float)value;
                onPropertyChanged(nameof(amount));
            }
        }

        public string date
        {
            set
            {
                exp.date = value;
                onPropertyChanged(nameof(date));
            }
        }

        public string description
        {
            set
            {
                exp.description = value;
                onPropertyChanged(nameof(description));
            }
        }
        /*
        public String  SelectedItems
        {
            set
            {
                selected_categories.Add(value);
            }
        }
        */
        public String IsSelected
        {
            set
            {
                selected_categories.Add(value);
            }
        }

        private ICommand _path;
        public ICommand path
        {
            get
            {
                if (_path == null)
                {
                    _path = new RelayCommand(param => this.GetPath(), param => this.CanPath());
                }
                return _path;
            }
        }

        private bool CanPath()
        {
            return true;
        }

        private void GetPath()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                exp.bill_photo_path = openFileDialog.FileName;
            }
        }

        

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                exp.creator_name = MainWindow.curr_name;
                if(MainWindow.curr_type==3)
                    exp.if_childs = true;
                else
                    exp.if_childs = false;
                exp.UserId = MainWindow.curr_id;
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(SaveObject, param => this.CanSave());
                }
                return _saveCommand;
            }
        }

        private bool CanSave()
        {
            return true;
        }

        private void SaveObject(Object param)
        {
            exp.add();
            System.Collections.IList items = (System.Collections.IList)param;
            var collection = items.Cast<String>();
            foreach (var item in collection)
            {
                exp_cat.newitem(item);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
