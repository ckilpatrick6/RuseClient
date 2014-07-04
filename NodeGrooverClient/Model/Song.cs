using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class Song: INotifyPropertyChanged
    {
        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("albumId")]
        public string AlbumID { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artistId")]
        public string ArtistID { get; set; }

        [JsonProperty("nid")]
        public string Id { get; set; }

        [JsonProperty("albumArtRef")]
        public string AlbumArt { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }

        [JsonProperty("vlcid")]
        public int VlcId { get; set; }


        [JsonProperty("current")]
        public bool Current { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Song))
                return false;
            return ((obj as Song).Id == this.Id) && ((obj as Song).VlcId == this.VlcId);
        }




        public event PropertyChangedEventHandler PropertyChanged;
    }

}
