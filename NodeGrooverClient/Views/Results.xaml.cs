using Elysium.Controls;
using NodeGrooverClient.Model;
using NodeGrooverClient.Net;
using NodeGrooverClient.ViewModel;
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
        public Results()
        {
            InitializeComponent();
        }

        private void ShowAlbum_Click(object sender, RoutedEventArgs e)
        {
            CommandButton button = (sender as CommandButton);
            AlbumOverlay overlay = new AlbumOverlay
            {
                DataContext = new AlbumViewModel(button.Tag.ToString()),
                Owner = System.Windows.Window.GetWindow(this),
                Style = (Style)this.FindResource("DarkOverlayWindowStyle")
            };
            overlay.Show();
        }

        private void ShowArtist_Click(object sender, RoutedEventArgs e)
        {
            CommandButton button = (sender as CommandButton);
            ArtistOverlay overlay = new ArtistOverlay
            {
                DataContext = new ArtistViewModel(button.Tag.ToString()),
                Owner = System.Windows.Window.GetWindow(this),
                Style = (Style)this.FindResource("DarkOverlayWindowStyle")
            };
            overlay.Show();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label label = (Label)sender;
            label.ContextMenu.IsOpen = true;
        }
    }
}
