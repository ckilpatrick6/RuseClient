
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using NodeGrooverClient.Net;
using System.Diagnostics;
using NodeGrooverClient.Model;

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for ContextWindow.xaml
    /// </summary>
    public partial class ContextWindow : Elysium.Controls.Window
    {
        Album currentAlbum;
        public ContextWindow(Album a)
        {
            InitializeComponent();
         //   currentAlbum = a;
           // loadSongs();
        }
        //public async void loadSongs()
        //{
        //    await LastFMAPI.getAlbumTracks(currentAlbum);
        //    List<Song> tracks = await LastFMAPI.getGSSongs(currentAlbum.Tracks, currentAlbum.Artist, currentAlbum.Name);
        //    trackListView.ItemsSource = currentAlbum.Tracks;
            
        //}

        private void Window_Deactivated(object sender, EventArgs e)
        {
        //    Debug.WriteLine("Deactivated");
        }

     

    }
}
