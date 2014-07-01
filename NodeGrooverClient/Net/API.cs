using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodeGrooverClient.Model;
using NodeGrooverClient.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WampSharp;
using WampSharp.Rpc;

namespace NodeGrooverClient.Net
{
    public class API
    {
        IWampChannel<JToken> channel;
        IPlayer player;
            

        public API()
        {
            DefaultWampChannelFactory channelFactory = new DefaultWampChannelFactory();
            channel = channelFactory.CreateChannel("ws://localhost:3000");
            channel.Open();
            player = channel.GetRpcProxy<IPlayer>();
  

        }
        public async Task<SearchResult> search(string query)
        {
            Task<string> task = player.search(query);
            string json = await task;
            SearchResult result = JsonConvert.DeserializeObject<SearchResult>(json);
            return result;
        }



        public void playSong(Song s)
        {
            
        }

        public void queueSong(Song s)
        {
            //socket.Emit("queue", s.SongID);
        }


        public void skip()
        {
            player.next();
        }

        public void prev()
        {
            player.prev();
        }
        public void pause()
        {
            player.pause();
        }

        public void resume()
        {
            player.resume();
        }
        public void setVolume(int volume)
        {
            player.volume(volume);
        }
        public void delete(int id)
        {
            player.delete(id);
        }
        public void gotoSong(int id)
        {
            player.goTo(id);
        }

    }
    public interface IPlayer
    {
        [WampRpcMethod("com.ruse.playsong")]
        void playSong(string songid);

        [WampRpcMethod("com.ruse.queuesong")]
        void queueSong(string songid);
        
        [WampRpcMethod("com.ruse.next")]
        void next();

        [WampRpcMethod("com.ruse.prev")]
        void prev();

        [WampRpcMethod("com.ruse.pause")]
        void pause();

        [WampRpcMethod("com.ruse.resume")]
        void resume();

        [WampRpcMethod("com.ruse.volume")]
        void volume(int value);

        [WampRpcMethod("com.ruse.goto")]
        void goTo(int id);

        [WampRpcMethod("com.ruse.delete")]
        void delete(int id);

        [WampRpcMethod("com.ruse.search")]
        Task<string> search(string query);
    }
}

