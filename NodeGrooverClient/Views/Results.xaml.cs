using Elysium.Controls;
using NodeGrooverClient.Model;
using NodeGrooverClient.Model.LastFm;
using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : UserControl
    {
        API api;
        ObservableCollection<Song> currentSearch;
        public Results()
        {
            InitializeComponent();
            api = API.getInstance();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            search();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            int item = (int)(sender as CommandButton).Tag;
            Song s = currentSearch[item];
            api.playSong(s);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int item = (int)(sender as CommandButton).Tag;
            Song s = currentSearch[item];
            api.queueSong(s);
        }

        private async void search()
        {
            progressBar.Visibility = Visibility.Visible;
            currentSearch = new ObservableCollection<Song>(await api.searchSongs(searchBox.Text));
            listView.ItemsSource = currentSearch;
           // List<Artist> artists = await LastFMAPI.searchArtist(searchBox.Text);
           // artistslistView.ItemsSource = artists;
            progressBar.Visibility = Visibility.Collapsed;
        }
        private void searchBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                search();
            }
        }

        private async void artistslistView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Artist artist = artistslistView.SelectedItem as Artist;
            if (artist != null)
            {
                artistBox.Text = artist.Name;
                if(artist.ImageUrl!="")
                    artistImage.Source = new BitmapImage(new Uri(artist.ImageUrl));
                
                List<Album> topalbums = await LastFMAPI.getArtistTopAlbums(artist.mbid);
                topalbumslistview.ItemsSource = topalbums;
            }

        }

    
        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null)
            {
                item.IsSelected = true;
                Album a = topalbumslistview.SelectedItem as Album;
                item.IsSelected = false;
                ContextWindow window = new ContextWindow(a);
                window.ShowDialog();
            }
        }

       


    }
}
