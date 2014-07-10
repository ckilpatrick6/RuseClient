﻿using NodeGrooverClient.Helpers;
using NodeGrooverClient.Model;
using NodeGrooverClient.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

[assembly: XmlnsDefinition("http://abettadapur.com/NodeGrooverClient/ViewModel", "NodeGrooverClient.ViewModel")]
namespace NodeGrooverClient.ViewModel
{
    public class SearchViewModel: ViewModel
    {
        private SearchResult _results;
        
        public SearchResult Results
        {
            get
            {
                return _results;
            }

        }

        

        private string _query;

        public string Query
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
                OnPropertyChanged("Query");
            }
        }

        public RelayCommand SearchCommand { get; set; }
        public RelayCommand PlayCommand { get; set; }
        public RelayCommand QueueCommand { get; set; }
        public RelayCommand PlayAlbumCommand { get; set; }
        public RelayCommand ShowAlbumCommand { get; set; }

        public SearchViewModel()
        {
            SearchCommand = new RelayCommand(search);
            PlayCommand = new RelayCommand(play);
            QueueCommand = new RelayCommand(queue);
            PlayAlbumCommand = new RelayCommand(playAlbum);
            ShowAlbumCommand = new RelayCommand(openAlbumWindow);

        }

        async void search(object parameter)
        {
            if(_query=="")
                return;

            _results = await (Application.Current as App).Api.search(_query);
            OnPropertyChanged("Results");
        }
        void play(object parameter)
        {
            if (parameter == null)
                return;
            (Application.Current as App).Api.play(parameter.ToString());
        }
        void queue(object parameter)
        {
            if (parameter == null)
                return;
            (Application.Current as App).Api.queue(parameter.ToString());
        }
        void playAlbum(object parameter)
        {
            if (parameter == null)
                return;
            (Application.Current as App).Api.playAlbum(parameter.ToString());
        }

        void openAlbumWindow(object parameter)
        {
            AlbumOverlay overlay = new AlbumOverlay
            {
                DataContext = new AlbumViewModel(parameter.ToString())
            };
            overlay.Show();
        }
        void openArtistWindow(object parameter)
        {

        }

    }

}
