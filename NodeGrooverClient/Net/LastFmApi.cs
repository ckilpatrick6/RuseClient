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
            try
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
            catch(WebException wex)
            {
                return "";
            }

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
                JObject imageObj = (JObject)imageList.Where(c => (string)c["size"] == "extralarge").First();
                album.ImageUrl = (string)imageObj["#text"];
                albums.Add(album);
            }



            return albums;
        }

        public static async Task<Album> getAlbumTracks(Album a)
        {
            StringBuilder url = new StringBuilder();
            url.Append("http://ws.audioscrobbler.com/2.0/?method=album.getinfo");
            url.Append("&api_key=");
            url.Append(APIKEY);
            url.Append("&album=");
            url.Append(a.Name);
            url.Append("&artist=");
            url.Append(a.Artist);
            url.Append("&format=json");

            WebRequest request = WebRequest.Create(url.ToString());
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            JObject results = JObject.Parse(json);
            JArray trackResults = (JArray)results["album"]["tracks"]["track"];
            IList<JObject> trackList = trackResults.Select(c => (JObject)c).ToList();
            a.Tracks = new List<Track>();
            foreach (JObject trackObj in trackList)
            {
                Track track = new Track();
                track.Name = (string)trackObj["name"];
                track.Rank = (int)trackObj["@attr"]["rank"];
                a.Tracks.Add(track);

            }
            return a;
        }
        public static async Task<List<Artist>> searchArtist(string query)
        {
            StringBuilder url = new StringBuilder();
            url.Append("http://ws.audioscrobbler.com/2.0/?method=artist.search");
            url.Append("&api_key=");
            url.Append(APIKEY);
            url.Append("&artist=");
            url.Append(query);
            url.Append("&limit=10");
            url.Append("&format=json");

            WebRequest request = WebRequest.Create(url.ToString());
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            JObject results = JObject.Parse(json);
            JArray artistResults = (JArray)results["results"]["artistmatches"]["artist"];
            IList<JObject> artistList = artistResults.Select(c => (JObject)c).ToList();
            List<Artist> artists = new List<Artist>();
            foreach (JObject artistObj in artistList)
            {
                Artist artist = new Artist();
                artist.Name = (string)artistObj["name"];
                artist.mbid = (string)artistObj["mbid"];
                JArray images = (JArray)artistObj["image"];
                IList<JObject> imageList = images.Select(c => (JObject)c).ToList();
                JObject imageObj = (JObject)imageList.Where(c => (string)c["size"] == "extralarge").First();
                artist.ImageUrl = (string)imageObj["#text"];
                artists.Add(artist);

            }
            return artists;
        }
        public static async Task<List<Album>> getArtistTopAlbums(string mbid)
        {
            StringBuilder url = new StringBuilder();
            url.Append("http://ws.audioscrobbler.com/2.0/?method=artist.getTopAlbums");
            url.Append("&api_key=");
            url.Append(APIKEY);
            url.Append("&mbid=");
            url.Append(mbid);
            url.Append("&limit=15");
            url.Append("&format=json");

            WebRequest request = WebRequest.Create(url.ToString());
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();

            JObject results = JObject.Parse(json);
            try
            {
                JArray albumResults = (JArray)results["topalbums"]["album"];
                IList<JObject> albumObjects = albumResults.Select(c => (JObject)c).ToList();
                List<Album> albums = new List<Album>();
            
            foreach (JObject albumResult in albumObjects)
            {
                Album album = new Album();
                album.Name = (string)albumResult["name"];
                album.Artist = (string)albumResult["artist"]["name"];
                JArray images = (JArray)albumResult["image"];
                IList<JObject> imageList = images.Select(c => (JObject)c).ToList();
                JObject imageObj = (JObject)imageList.Where(c => (string)c["size"] == "extralarge").First();
                album.ImageUrl = (string)imageObj["#text"];
                albums.Add(album);
            }



            return albums;
            }
            catch (InvalidCastException icex)
            {
                JObject albumResult = (JObject)results["topalbums"]["album"];
                Album album = new Album();
                album.Name = (string)albumResult["name"];
                album.Artist = (string)albumResult["artist"]["name"];
                JArray images = (JArray)albumResult["image"];
                IList<JObject> imageList = images.Select(c => (JObject)c).ToList();
                JObject imageObj = (JObject)imageList.Where(c => (string)c["size"] == "extralarge").First();
                album.ImageUrl = (string)imageObj["#text"];
                List<Album> albums = new List<Album>();
                albums.Add(album);
                return albums;
            }

        }
        public async static Task<List<Song>> getGSSongs(List<Track> tracks, string artist, string album)
        {
            stripTitles(tracks);
            List<Song> songs = new List<Song>();
            API api = API.getInstance();
            foreach(Track t in tracks)
            {
                //try
                //{
                //need to escape possible / in song names
                    var searchResults = await api.searchSongs(t.Name + " " + artist);

                    foreach (Song s in searchResults)
                    {
                        if (s.Name.ToLower() == t.Name.ToLower() && s.ArtistName.ToLower() == artist.ToLower())
                        {
                            songs.Add(s); break;
                        }
                    }
                //}
                //catch (WebException wex)
                //{
                    
                //}
            
            }
            for(int i=0; i<songs.Count; i++)
            {
                songs[i].Count = i;
            }
            return songs;
        }

        private static void stripTitles(List<Track> tracks)
        {
            foreach(Track t in tracks)
            {
                if(t.Name.ToLower().Contains("(album version)"))
                {
                    int index = t.Name.ToLower().IndexOf("(album version)");
                    t.Name = t.Name.Remove(index-1, "(album version)".Length);
                }
            }
        }
     }
}
