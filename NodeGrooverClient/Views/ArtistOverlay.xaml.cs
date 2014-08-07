using Elysium.Controls;
using Framework.UI.Controls;
using NodeGrooverClient.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for ArtistOverlay.xaml
    /// </summary>
    public partial class ArtistOverlay : OverlayWindow
    {
        public ArtistOverlay()
        {
            InitializeComponent();
        }

        private void CommandButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    }
}
