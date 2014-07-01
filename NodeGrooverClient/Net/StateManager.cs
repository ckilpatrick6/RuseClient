using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
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

        public static void registerListener(IStatusListener listener)
        {
            if(listeners == null)
                listeners = new List<IStatusListener>();

            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }
        public static void updateListeners(Status status)
        {
            if(listeners!=null)
                foreach(IStatusListener listener in listeners)
                {
                    listener.updateStatus(status);
                }
        }






    }


}
