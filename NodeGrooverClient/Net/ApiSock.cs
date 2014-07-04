using Newtonsoft.Json;
using NodeGrooverClient.Model;
using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Net
{
    public class Api
    {
        Client socket;
        string uri;
        public Api(string uri)
        {
            this.uri = uri;
            socket = new Client(this.uri);
            configureSocket();
        }
        private void configureSocket()
        {
            socket.On("status", "/ruse", (fn) =>
                {
                    Status s = JsonConvert.DeserializeObject<Status>(fn.Json.Args[0]);
                    StateManager.updateListeners(s);
                });
            socket.Connect("/ruse");
        }

        public async Task<SearchResult> search(string query)
        {
            SearchResult result;
            string url = this.uri + "search?query=" + query;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = await request.GetResponseAsync();
            Stream respStream = response.GetResponseStream();
            using(StreamReader reader = new StreamReader(respStream))
            {
                string json = reader.ReadToEnd();
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(json);
            }
            return result;
        }
        public void play(string id)
        {
            socket.Emit("play", id, "/ruse");
        }
        
        public void queue(string id)
        {
            socket.Emit("queue", id, "/ruse");
        }

        public void next()
        {
            socket.Emit("next", "", "/ruse");
        }

        public void prev()
        {
            socket.Emit("prev", "", "/ruse");
        }

        public void pause()
        {
            socket.Emit("pause", "", "/ruse");
        }

        public void resume()
        {
            socket.Emit("resume", "", "/ruse");
        }

        public void volume(int val)
        {
            socket.Emit("volume", val, "/ruse");
        }

        public void delete(int id)
        {
            socket.Emit("delete", id, "/ruse");
        }
        
        public void goTo(int id)
        {
            socket.Emit("goto", id, "/ruse");
        }

        public void playAlbum(string p)
        {
            socket.Emit("playalbum", p, "/ruse");
        }
    }
}
