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
    /// Interaction logic for TabView.xaml
    /// </summary>
    public partial class TabView : UserControl
    {
        public TabView()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            /*RadioButton rb = sender as RadioButton;
            if (rb.Content.ToString() == "Search")
            {
                Switcher.Switch(new Search());
            }
            else if (rb.Content.ToString() == "Now Playing")
            {
                Switcher.Switch(new NowPlaying());
            }*/
        }
        public void selectButton(int i)
        {
            switch (i)
            {
                case 0: SearchButton.IsChecked = true; break;
                case 1: NowPlayingButton.IsChecked = true; break;
                case 2: SettingsButton.IsChecked = true; break;
            }
        }

        private void SettingsButton_LostMouseCapture(object sender, MouseEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Content.ToString() == "Search")
            {
                Switcher.Switch(new Search());
            }
            else if (rb.Content.ToString() == "Now Playing")
            {
                Switcher.Switch(new NowPlaying());
            }
            else if (rb.Content.ToString() == "Settings")
            {
                Switcher.Switch(new Settings());
            }
        }
    }
}
