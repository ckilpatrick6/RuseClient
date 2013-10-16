using NodeGrooverClient.Model;
using NodeGrooverClient.Properties;
using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient.Net
{
    public class API
    {
        private string _Host;
        public string Host { get { return _Host; } }
        private int _Port;
        public int Port { get { return _Port; } }
        private static API instance;
        private Client socket;

        private API()
        {
            this._Host = Settings.Default.Properties["Host"].DefaultValue.ToString();
            this._Port = int.Parse(Settings.Default.Properties["Port"].DefaultValue.ToString());
        }
        public void connectSocket()
        {
            socket = new Client("http://" + Host + ":" + Port);
            configureSocket(socket);
        }
        public void changeHost()
        {
            this._Host = Settings.Default.Properties["Host"].DefaultValue.ToString();
            this._Port = (int)Settings.Default.Properties["Port"].DefaultValue;
            socket.Dispose();
            connectSocket();
        }
        private void configureSocket(Client socket)
        {
            socket.On("status", (fn) =>
                {
                    Debug.WriteLine("GotStatusIO");
                    string json = fn.Json.ToJsonString();
                    Debug.WriteLine(json);
                    Status status = (Newtonsoft.Json.JsonConvert.DeserializeObject<StatusWrapper>(json)).args[0];
                    StateManager.updateAllListeners(status);

                });
            socket.On("test", (fn) =>
                {
                    Debug.WriteLine("TOTAL SUCCESS");
                });
            socket.Connect();
        }

        public static API getInstance()
        {
            if(instance == null)
                instance = new API();
            
            return instance;
        }



        public async Task<Song[]> searchSongs(string query)
        {
            Debug.WriteLine(DateTime.Now + ": Getting http://search");
            Song[] results;
            string url = "http://"+Host + ":" + Port + "/lib/search/" + query;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = await request.GetResponseAsync();
            Debug.WriteLine(DateTime.Now + ": Recieved response for http://search");
            Stream respStream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(respStream))
            {
                string json = reader.ReadToEnd();
                results = Newtonsoft.Json.JsonConvert.DeserializeObject<Song[]>(json);
            }
            for (int i = 0; i < results.Length; i++)
            {
                results[i].Count = i;
            }
            return results;
        }

        

        public void playSong(Song s)
        {
            socket.Emit("play", s.SongID);
        }

        public void queueSong(Song s)
        {
            socket.Emit("queue", s.SongID);
        }

        public void skip()
        {
            socket.Emit("skip", "");
        }

        public void prev()
        {
            socket.Emit("prev", "");
        }
        public void pause()
        {
            socket.Emit("pause", "");
        }

        public void resume()
        {
            socket.Emit("resume", "");
        }
        public void setVolume(int volume)
        {
            socket.Emit("volume", volume);
        }
        public void delete(Song s)
        {
            socket.Emit("delete", s.Count);
        }
        public void gotoSong(int id)
        {
            socket.Emit("goto", id);
        }
    }
}
