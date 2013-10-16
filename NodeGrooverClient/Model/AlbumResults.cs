using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class AlbumResults
    {

        public Results results { get; set; }
    }
    public class Results
    {
        public AlbumMatches albummatches { get; set; }
    }
    public class AlbumMatches
    {
        public Album[] album { get; set; }
    }
    public class Album
    {
        public Image[] image { get; set; }
        public string name { get; set; }
        public string artist { get; set; }
    }
    public class Image
    {
        [JsonProperty("#text")]
        public string url { get; set; }
        public string size { get; set; }
    }
}
