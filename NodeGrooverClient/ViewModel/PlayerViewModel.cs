using NodeGrooverClient.Helpers;
using NodeGrooverClient.Model;
using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient.ViewModel
{
    class PlayerViewModel: ViewModel, IStatusListener
    {
        private Status _status;
        public Status Status
        {
            get
            {
                return _status;
            }
        }

       

        public void updateStatus(Status status)
        {
            _status = status;
            OnPropertyChanged("Status");
           
        }

        public RelayCommand PlayCommand { get; set; }
        public RelayCommand NextCommand { get; set; }
        public RelayCommand PrevCommand { get; set; }

        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand GotoCommand { get; set; }


        public PlayerViewModel()
        {
            StateManager.registerListener(this);
            PlayCommand = new RelayCommand(play);
            NextCommand = new RelayCommand(next);
            PrevCommand = new RelayCommand(prev);
            DeleteCommand = new RelayCommand(delete);
            GotoCommand = new RelayCommand(goTo);
        }

        void play(object parameter)
        {
            if (Status.Playing)
                (Application.Current as App).Api.pause();
            else
                (Application.Current as App).Api.resume();
        }

        void next(object parameter)
        {
            (Application.Current as App).Api.next();
        }

        void prev(object parameter)
        {
            (Application.Current as App).Api.prev();
        }

        void delete(object parameter)
        {
            (Application.Current as App).Api.delete((int)parameter);
        }

        void goTo(object parameter)
        {
            (Application.Current as App).Api.goTo((int)parameter);
        }

        
    }
}
