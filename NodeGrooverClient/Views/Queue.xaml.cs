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

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for Queue.xaml
    /// </summary>
    public partial class Queue : UserControl, StatusListeners
    {
        ObservableCollection<Song> songs = new ObservableCollection<Song>();
        public Queue()
        {
            InitializeComponent();
            StateManager.registerListener(this);
            nowPlayingList.ItemsSource = songs;
        }
        public void updateStatus(Model.Status s)
        {
            songs.Clear();
            int count = 0;
            foreach (Song song in s.queue)
            {
                if (song.Current)
                {
                    song.Time = s.songTime;
                    song.Max = s.currentSongLength;
                }
                song.Count = count++;
                songs.Add(song);

            }
        }

        private void CommandButton_Click_1(object sender, RoutedEventArgs e)
        {
            API api = API.getInstance();
            int count = (int)(sender as CommandButton).Tag;
            api.gotoSong(count);
        }
    }
}
