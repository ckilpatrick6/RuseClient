using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class Artist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("artistId")]
        public string Id { get; set; }

        [JsonProperty("artistArtRef")]
        public string Art { get; set; }

    }
}
