using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class YoutubeSong
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnails Thumbnail { get; set; }

        public int Count { get; set; }

    }
}
