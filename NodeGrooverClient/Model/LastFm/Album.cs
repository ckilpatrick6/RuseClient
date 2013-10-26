using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodeGrooverClient.Model.LastFm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model.LastFm
{
    public class Album
    {
       
        public string Artist { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Track[] Tracks { get; set; }

    }
}
