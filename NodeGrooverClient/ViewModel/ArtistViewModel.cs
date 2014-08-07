using NodeGrooverClient.Helpers;
using NodeGrooverClient.Model;
using NodeGrooverClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient.ViewModel
{
    public class ArtistViewModel: ViewModel
    {
        private readonly string id;

        private Artist _artist;
        public Artist Artist
        {
            get
            {
                return _artist;
            }
        }

        public RelayCommand PlayCommand { get; set; }
        public RelayCommand QueueCommand { get; set; }
        public RelayCommand PlayAlbumCommand { get; set; }
        public RelayCommand OpenAlbumCommand { get; set; }

        public ArtistViewModel(string id)
        {
            this.id = id;
            loadArtist();
            PlayCommand = new RelayCommand(playSong);
            QueueCommand = new RelayCommand(queueSong);
            PlayAlbumCommand = new RelayCommand(playAlbum);
            OpenAlbumCommand = new RelayCommand(openAlbum);

        }

        private async void loadArtist()
        {
            _artist = await (Application.Current as App).Api.getArtist(id);
            OnPropertyChanged("Artist");
        }

        public void playSong(object id)
        {
            (Application.Current as App).Api.play(id.ToString());
        }
        public void queueSong(object id)
        {
            (Application.Current as App).Api.queue(id.ToString());
        }
        public void playAlbum(object id)
        {
            (Application.Current as App).Api.playAlbum(id.ToString());
        }
        public void openAlbum(object id)
        {
            AlbumOverlay overlay = new AlbumOverlay
            {
                DataContext = new AlbumViewModel(id.ToString())
            };
            overlay.Show();
        }

    }
}
