using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class Album
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("albumId")]
        public string Id { get; set; }

        [JsonProperty("artist")]
        public string ArtistName { get; set; }

        [JsonProperty("artistId")]
        public string ArtistId { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("albumArtRef")]
        public string Art { get; set; }

        [JsonProperty("tracks")]
        public Song[] Songs { get; set; }
    }
}
