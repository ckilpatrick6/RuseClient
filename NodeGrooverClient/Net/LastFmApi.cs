using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodeGrooverClient.Model;
using NodeGrooverClient.Model.LastFm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Net
{
    
    public class LastFMAPI
    {
        public const string APIKEY = "08dd2c001a8176908e4feb6bd51391a1";

        public static async Task<string> getArt(Song s)
        {
            List<Album> results = await searchAlbum(s.AlbumName);
         
            
            foreach (Album a in results)
            {
                if (a.Artist.ToLower() == s.ArtistName.ToLower() && a.Name.ToLower() == s.AlbumName.ToLower())
                {
                    return a.ImageUrl;
                }
            }

            return ""; //need default;

        }
        public static async Task<List<Album>> searchAlbum(string query)
        {
            StringBuilder url = new StringBuilder();
            url.Append("http://ws.audioscrobbler.com/2.0/?method=album.search");
            url.Append("&api_key=");
            url.Append(APIKEY);
            url.Append("&album=");
            url.Append(query);
            url.Append("&format=json");

            WebRequest request = WebRequest.Create(url.ToString());
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            JObject albumresults = JObject.Parse(json);
            JArray albummatches = (JArray)albumresults["results"]["albummatches"]["album"];
            IList<JObject> albumObjects = albummatches.Select(c => (JObject)c).ToList();
            List<Album> albums = new List<Album>();
            
            foreach(JObject albumResult in albumObjects)
            {
                Album album = new Album();
                album.Name = (string)albumResult["name"];
                album.Artist = (string)albumResult["artist"];
                JArray images = (JArray)albumResult["image"];
                IList<JObject> imageList = images.Select(c => (JObject)c).ToList();
                JObject imageObj = (JObject)imageList.Where(c => (string)c["size"] == "medium").First();
                album.ImageUrl = (string)imageObj["#text"];
                albums.Add(album);
            }



            return albums;
        }
    }
}
