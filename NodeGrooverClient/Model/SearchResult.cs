using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class SearchResult
    {
        [JsonProperty("song_hits")]
        public ObservableCollection<Song> Songs { get; set; }

        [JsonProperty("artist_hits")]
        public ObservableCollection<Artist> Artists { get; set; }

        [JsonProperty("album_hits")]
        public ObservableCollection<Album> Albums { get; set; }
    }
}
