using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class Status
    {
        [JsonProperty("volume")]
        public int Volume { get; set; }
        
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("playing")]
        public bool Playing { get; set; }

        [JsonProperty("current")]
        public Song Current { get; set; }

    }
}
