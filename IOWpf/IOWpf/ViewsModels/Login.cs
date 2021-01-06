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
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class Login : INotifyPropertyChanged
    {
        private ObservableCollection<string> usersList;
        

        /*
        public string username
        {
            get { return username; }
            set
            {
                username = value;
                onPropertyChanged(nameof(username));
            }
        }

        public string password
        {
            get { return password; }
            set
            {
                password = value;
                onPropertyChanged(nameof(password));
            }
        }
        */

/*
        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                Inc.creator_name = MainWindow.curr_name;
                if (MainWindow.curr_type == 3)
                    Inc.if_childs = true;
                else
                    Inc.if_childs = false;
                Inc.UserId = MainWindow.curr_id;

                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(param => this.SaveObject(), param => this.CanSave()
                    );
                }
                return _saveCommand;
            }
        }

        private bool CanSave()
        {
            return true;
        }

        private void SaveObject()
        {
            Inc.add();
        }

        */


        public ObservableCollection<string> GetUsersList()
        {
            return usersList;
        }

        public void SetUsersList(ObservableCollection<string> value)
        {
            usersList = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
