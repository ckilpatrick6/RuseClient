using Newtonsoft.Json;
using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Net
{
    
    public class ArtAPI
    {
        public const string APIKEY = "08dd2c001a8176908e4feb6bd51391a1";

        public static async Task<string> getArt(Song s)
        {
            AlbumResults results = await getAlbum(s.AlbumName);
            Album[] albums = results.results.albummatches.album;
            Album match = null;
            foreach (Album a in albums)
            {
                if (a.artist.ToLower() == s.ArtistName.ToLower() && a.name.ToLower() == s.AlbumName.ToLower())
                {
                    match = a;
                    break;
                }
            }
            if (match == null)
            {
                return "";
                //return generic image
            }
            else
                return match.image[2].url; 

        }
        public static async Task<AlbumResults> getAlbum(string album)
        {
            StringBuilder url = new StringBuilder();
            url.Append("http://ws.audioscrobbler.com/2.0/?method=album.search");
            url.Append("&api_key=");
            url.Append(APIKEY);
            url.Append("&album=");
            url.Append(album);
            url.Append("&format=json");

            WebRequest request = WebRequest.Create(url.ToString());
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            AlbumResults result = JsonConvert.DeserializeObject<AlbumResults>(json);

            return result;
        }
    }
}
