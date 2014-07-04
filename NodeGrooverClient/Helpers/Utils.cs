using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Helpers
{
    public class Utils
    {
        public static void mirrorCollections(ObservableCollection<Song> source, ObservableCollection<Song> dest)
        {
            foreach(Song s in source)
            {
                if (!dest.Contains(s))
                    dest.Add(s);
                if(s.Current)
                {
                    Song dest_song = dest[dest.IndexOf(s)];
                    dest_song.Current = true;
                }
            }
            List<Song> toRemove = new List<Song>();
            foreach(Song s in dest)
            {
                if (!source.Contains(s))
                    toRemove.Add(s);
                if (s.Current)
                {
                    if (!source[source.IndexOf(s)].Current)
                        s.Current = false;
                }
            }
            foreach(Song s in toRemove)
            {
                dest.Remove(s);
            }
        }
    }
}
