using Elysium.Controls;
using NodeGrooverClient.Model;
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

namespace NodeGrooverClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Elysium.Controls.Window, StatusListeners
    {
        API api;
        bool playing=false;
        ObservableCollection<Song> currentSearch;
        public MainWindow()
        {
            InitializeComponent();
            StateManager.registerListener(this);
            api = API.getInstance();
        }


        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            progressBar.Visibility = Visibility.Visible;
            currentSearch = new ObservableCollection<Song>(await api.searchSongs(searchBox.Text));
            listView.ItemsSource = currentSearch;
            progressBar.Visibility = Visibility.Collapsed;
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

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (playing)
                api.pause();
            else
                api.resume();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            api.skip();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            api.prev();
        }




        public void updateStatus(Status s)
        {
            PauseButton.Content = (playing = s.playState == "paused" || s.playState == "stopped") ? "\uE102" : "\uE103";
            playing = !playing;

            SongScrubber.Value = s.position * 100.0;

            int currentSeconds = s.songTime;
            int currentMinutes = currentSeconds / 60;
            currentSeconds = currentSeconds % 60;

            songTimeBlock.Text = currentMinutes + ":" + ((currentSeconds < 10) ? "0" + currentSeconds : currentSeconds.ToString());

            currentSeconds = s.currentSongLength;
            currentMinutes = currentSeconds / 60;
            currentSeconds = currentSeconds % 60;

            songMaxBlock.Text = currentMinutes + ":" + ((currentSeconds<10)?"0"+currentSeconds:currentSeconds.ToString());

            if (s.information != null)
            {
                string url = s.information.category.meta.filename;
                string name = "";
                foreach (Song song in s.queue)
                {
                    if (song.Url == url)
                    {
                        name = song.Name;
                        break;
                    }
                }
                nowPlayingBlock.Text = name;
            }

            int volume = (int)((s.volume / 512.0) * 100);
            VolumeSlider.Value = volume;
            VolumeLabel.Text = volume.ToString();
        }

        private void VolumeSlider_LostMouseCapture(object sender, MouseEventArgs e)
        {
            double value = ((int)((Slider)sender).Value) / 100.0;
            value = value * 512.0;
            api.setVolume((int)value);
            VolumeSlider.IsEnabled = true;
        }


    }
}
