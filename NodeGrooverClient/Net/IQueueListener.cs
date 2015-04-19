using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Net
{
    public interface IQueueListener
    {
        void updateQueue(ObservableCollection<Song> queue);
    }
}
