using NodeGrooverClient.Helpers;
using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient.ViewModel
{
    public class AlbumViewModel: ViewModel
    {
        private readonly string id;

        private Album _album;
        public Album Album
        {
            get
            {
                return _album;
            }
        }

        public RelayCommand PlayCommand { get; set; }
        public RelayCommand QueueCommand { get; set; }
        public RelayCommand PlayAlbumCommand { get; set; }
        public RelayCommand QueueAlbumCommand { get; set; }

        public AlbumViewModel(string id)
        {
            this.id = id;
            loadAlbum();
            PlayCommand = new RelayCommand(playSong);
            QueueCommand = new RelayCommand(queueSong);
            PlayAlbumCommand = new RelayCommand(playAlbum);
            QueueAlbumCommand = new RelayCommand(queueAlbum);
        }

        private async void loadAlbum()
        {
            _album = await (Application.Current as App).Api.getAlbum(id);
            OnPropertyChanged("Album");
        }

        private void playSong(object parameter)
        {
            (Application.Current as App).Api.play(parameter.ToString());
        }
        private void queueSong(object parameter)
        {
            (Application.Current as App).Api.queue(parameter.ToString());
        }

        private void playAlbum(object parameter)
        {
            (Application.Current as App).Api.playAlbum(id);
        }

        private void queueAlbum(object parameter)
        {
            (Application.Current as App).Api.queueAlbum(id);
        }
    }
}
