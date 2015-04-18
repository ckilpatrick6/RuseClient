using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace NodeGrooverClient.Net
{
    public class StateManager
    {

        private static List<IStatusListener> listeners;
        private static List<IQueueListener> queue_listeners;

        public static void registerListener(IStatusListener listener)
        {
            if(listeners == null)
                listeners = new List<IStatusListener>();

            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public static void registerQueueListener(IQueueListener listener)
        {
            if (queue_listeners == null)
                queue_listeners = new List<IQueueListener>();

            if (!queue_listeners.Contains(listener))
                queue_listeners.Add(listener);
        }
        public static void updateStatusListeners(Status status)
        {
            if(listeners!=null)
                foreach(IStatusListener listener in listeners)
                {
                    listener.updateStatus(status);
                }
        }

        public static void updateQueueListeners(ObservableCollection<Song> queue)
        {
            if (queue_listeners != null)
                foreach (IQueueListener listener in listeners)
                {
                    listener.updateQueue(queue);
                }
        }








    }


}
