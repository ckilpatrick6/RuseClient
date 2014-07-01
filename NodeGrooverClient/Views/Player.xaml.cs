using Newtonsoft.Json;
using NodeGrooverClient.Model;
using NodeGrooverClient.Net;
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
//using Elysium.Notifications;

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl//, StatusListeners
    {
        //API api;
        //bool playing=false;
        //Song nowPlaying;
        public Player()
        {
            InitializeComponent();
            //api = API.getInstance();
            //StateManager.registerListener(this);
        }

        private void VolumeSlider_LostMouseCapture(object sender, MouseEventArgs e)
        {
            int val = (int)VolumeSlider.Value;
            (Application.Current as App).Api.volume(val);
        }
        //public async void updateStatus(Status s)
        //{
            
        //    PauseButton.Content = (playing = s.playState == "paused" || s.playState == "stopped") ? "\uE102" : "\uE103";
        //    playing = !playing;

        //    SongScrubber.Value = s.position * 100.0;

        //    int currentSeconds = s.songTime;
        //    int currentMinutes = currentSeconds / 60;
        //    currentSeconds = currentSeconds % 60;

        //    songTimeBlock.Text = currentMinutes + ":" + ((currentSeconds < 10) ? "0" + currentSeconds : currentSeconds.ToString());

        //    currentSeconds = s.currentSongLength;
        //    currentMinutes = currentSeconds / 60;
        //    currentSeconds = currentSeconds % 60;

        //    songMaxBlock.Text = currentMinutes + ":" + ((currentSeconds<10)?"0"+currentSeconds:currentSeconds.ToString());

        //    if (s.information != null)
        //    {
        //        string url = s.information.category.meta.filename;
        //        string name = "";
        //        string artist = "";
        //        foreach (Song song in s.queue)
        //        {
        //            if (song.Current)
        //            {
        //                name = song.Name;
        //                artist = song.ArtistName;
        //               if (nowPlaying==null||(song.Name != nowPlaying.Name&&song.ArtistName!=nowPlaying.ArtistName))
        //                {
        //                   // int num = await NotificationManager.TryPushAsync("Now Playing", song.Name+" by "+song.ArtistName) ? 1 : 0;
        //                    nowPlaying = song;
        //                    try
        //                    {
        //                        string image = await LastFMAPI.getArt(song);
        //                        if (image != "")
        //                        {
        //                            BitmapImage bitmap = new BitmapImage(new Uri(image));
        //                            albumArt.Source = bitmap;
        //                        }
        //                        else
        //                            albumArt.Source = null;
                                 
        //                    }
        //                    catch (JsonSerializationException jsex)
        //                    {
        //                        albumArt.Source = null;
        //                    }
        //                   catch (Exception ex)
        //                    {
        //                        albumArt.Source = null;
        //                    }
        //                }


        //                break;
        //            }
        //        }
        //        nowPlayingBlock.Text = name;
        //        artistBlock.Text = artist;
        //    }

        //    int volume = (int)((s.volume / 512.0) * 100);
        //    VolumeSlider.Value = volume;
        //    VolumeLabel.Text = volume.ToString();

  
       
        
    }
}
