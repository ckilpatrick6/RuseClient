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
  
        private static List<StatusListeners> listeners;
        private static List<ErrorListener> errorListener;

       

        public static  void updateAllListeners(Status s)
        {
            if (listeners != null)
            {
                foreach (StatusListeners sl in listeners)
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => sl.updateStatus(s)));
                }
            }
        }
        public static void errorListeners(int status)
        {
            for(int i=0; i<errorListener.Count; i++)
            {
                errorListener[i].raiseError("ERROR");
            }
        }
        public static void registerListener(StatusListeners sl)
        {
            if (listeners == null)
            {
                listeners = new List<StatusListeners>();
            }
            if (!listeners.Contains(sl))
                listeners.Add(sl);
        }
        public static void registerErrorListener(ErrorListener sl)
        {
            if (errorListener == null)
            {
                errorListener = new List<ErrorListener>();
            }
            if (!errorListener.Contains(sl))
                errorListener.Add(sl);
        }
        


    }


}
