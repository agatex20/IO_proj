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
    using System.Collections.ObjectModel;
    

    public class DodajUzytkownika : INotifyPropertyChanged
    {
        private String _username = "";
        public String username
        {
            get { return _username; }
            set
            {
                if (value != _username)
                {
                    _username = value;
                    onPropertyChanged(nameof(username));
                }
            }
        }

        private String _password = "";
        public String password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    onPropertyChanged(nameof(password));
                }
            }
        }




        private ICommand _addUserCommand;
        public ICommand addUserCommand
        {
            get
            {
               // _added = "Dodano";
                return _addUserCommand;
            }
            
        }


        private String _added = "";
        public String added
        {
            get { return _added; }
            set
            {
                if (value != _added)
                {
                    _added = value;
                    onPropertyChanged(nameof(added));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string property_name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property_name));
        }


    }
}
