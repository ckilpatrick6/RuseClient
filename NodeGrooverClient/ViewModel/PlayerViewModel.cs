using NodeGrooverClient.Helpers;
using NodeGrooverClient.Model;
using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace NodeGrooverClient.ViewModel
{
    class PlayerViewModel: ViewModel, IStatusListener, IQueueListener
    {
        private Status _status;
        public Status Status
        {
            get
            {
                return _status;
            }
        }

        private ObservableCollection<Song> _queue = new ObservableCollection<Song>();
        public ObservableCollection<Song> Queue
        {
            get
            {
                return _queue;
            }
        }

        private object _queueLock = new object();
        

       

        public void updateStatus(Status status)
        {
            _status = status;
            OnPropertyChanged("Status");
            //Utils.mirrorCollections(status.Queue, _queue);
            
        }

        public void updateQueue(ObservableCollection<Song> queue)
        {
            _queue = queue;
            OnPropertyChanged("Queue");
        }

        public RelayCommand PlayCommand { get; set; }
        public RelayCommand NextCommand { get; set; }
        public RelayCommand PrevCommand { get; set; }

        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand GotoCommand { get; set; }


        public PlayerViewModel()
        {
            StateManager.registerListener(this);
            StateManager.registerQueueListener(this);
            PlayCommand = new RelayCommand(play);
            NextCommand = new RelayCommand(next);
            PrevCommand = new RelayCommand(prev);
            DeleteCommand = new RelayCommand(delete);
            GotoCommand = new RelayCommand(goTo);

            BindingOperations.EnableCollectionSynchronization(_queue, _queueLock);
            _queue.CollectionChanged += _queue_CollectionChanged;
        }

        void _queue_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems != null)
            {
                foreach(Song item in e.NewItems)
                {
                    item.PropertyChanged += item_PropertyChanged;
                }
            }
        }

        void item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Current")
                OnPropertyChanged("Current");
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
