using NodeGrooverClient.Helpers;
using NodeGrooverClient.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient.ViewModel
{
    public class SettingsViewModel: ViewModel
    {
        private string _hostname;
        private string _port;

        public string Hostname
        {
            get
            {
                return _hostname;
            }
            set
            {
                _hostname = value;
                OnPropertyChanged("Hostname");
            }
        }

        public string Port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
                OnPropertyChanged("Port");
            }
        }

        public RelayCommand SaveCommand { get; set; }

        public SettingsViewModel()
        {
            SaveCommand = new RelayCommand(save);
            string uri = Settings.Default["endpoint"].ToString();
            _hostname = uri.Split(':')[1].Remove(0,2);
            _port = uri.Split(':')[2].Remove(uri.Split(':')[2].Length - 1);
        }
        public void save(object parameter)
        {
            if (_hostname == "")
                return;
            if (_port == "")
                _port = "80";

            if(!(_hostname.Contains("ws://")||_hostname.Contains("ws://")))
            {
                _hostname = "ws://"+_hostname;
            }

            string uri = _hostname + ":" + _port + "/ws";
            (Application.Current as App).changeUri(uri);
        }
    }
}
