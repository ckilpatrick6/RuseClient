using Newtonsoft.Json;
using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using WampSharp.V2;
using WampSharp.V2.Realm;
using WampSharp.V2.Rpc;

namespace NodeGrooverClient.Net
{
    public class Api
    {
        private string endpoint;
        private IWampChannel channel;
        private IRuseService service;
        public ISubject<string> queue_request;
        public Api(string uri)
        {
            Console.Out.Write("Starting API");
            this.endpoint = uri;
            var factory = new DefaultWampChannelFactory();
            channel = factory.CreateJsonChannel(endpoint, "realm1");
            channel.Open().Wait(5000);
            service = channel.RealmProxy.Services.GetCalleeProxy<IRuseService>();
            queue_request = channel.RealmProxy.Services.GetSubject<string>("com.ruse.queue_request");
            

            IDisposable status_sub =
                channel.RealmProxy.Services.GetSubject<string>("com.ruse.now_playing").Subscribe(x =>
                {
                    Console.Out.WriteLine("Got status: " + x);
                    Status s = JsonConvert.DeserializeObject<Status>(x);
                    StateManager.updateStatusListeners(s);
                });

            IDisposable queue_sub =
                channel.RealmProxy.Services.GetSubject<string>("com.ruse.queue").Subscribe(x =>
                {
                    Console.Out.WriteLine("Got queue: " + x);
                    ObservableCollection<Song> queue = JsonConvert.DeserializeObject<ObservableCollection<Song>>(x);
                    StateManager.updateQueueListeners(queue);
                });

            
        }

        public void request_queue()
        {
            queue_request.OnNext("");
        }

        public void disconnect()
        {
            channel.Close();
            channel = null;
            service = null;
        }

        public async Task<SearchResult> search(string query)
        {
            SearchResult result;
            string json = await service.search(query);
            result = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(json);
            return result;
        }

        public async Task<Album> getAlbum(string id)
        {
            Album album;
            string json = await service.get_album(id);
            album = Newtonsoft.Json.JsonConvert.DeserializeObject<Album>(json);
            return album;
        }

        public async Task<Artist> getArtist(string id)
        {
            Artist artist;
            string json = await service.get_artist(id);
            artist = Newtonsoft.Json.JsonConvert.DeserializeObject<Artist>(json);
            return artist;
        }
        public void play(string id)
        {
            service.play_song(id);
        }

        public void queue(string id)
        {
            service.queue_song(id);
        }

        public void next()
        {
            service.next();
        }

        public void prev()
        {
            service.prev();
        }

        public void pause()
        {
            service.pause();
        }

        public void resume()
        {
            service.resume();
        }

        public void volume(int val)
        {
            service.set_volume(val);
        }

        public void delete(int id)
        {
            service.delete(id);
        }

        public void goTo(int id)
        {
            service.go_to(id);
        }

        public void playAlbum(string p)
        {
            service.play_album(p);
        }

        public void queueAlbum(string id)
        {
            service.queue_album(id);
        }


    }

    public interface IRuseService
    {
        [WampProcedure("com.ruse.search")]
        Task<string> search(string query);

        [WampProcedure("com.ruse.get_album")]
        Task<string> get_album(string id);

        [WampProcedure("com.ruse.get_artist")]
        Task<string> get_artist(string id);

        [WampProcedure("com.ruse.play_song")]
        void play_song(string id);

        [WampProcedure("com.ruse.queue_song")]
        void queue_song(string id);

        [WampProcedure("com.ruse.play_album")]
        void play_album(string id);

        [WampProcedure("com.ruse.queue_album")]
        void queue_album(string id);

        [WampProcedure("com.ruse.set_volume")]
        void set_volume(int value);

        [WampProcedure("com.ruse.pause")]
        void pause();

        [WampProcedure("com.ruse.resume")]
        void resume();

        [WampProcedure("com.ruse.next")]
        void next();

        [WampProcedure("com.ruse.prev")]
        void prev();

        [WampProcedure("com.ruse.delete")]
        void delete(int id);

        [WampProcedure("com.ruse.goto")]
        void go_to(int id);

        [WampProcedure("com.ruse.flush")]
        void flush();
    }
}
