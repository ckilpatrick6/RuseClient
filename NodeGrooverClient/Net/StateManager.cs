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
        public static List<StatusListeners> Listeners { get; set; }
        public static DispatcherTimer UpdateTimer { get; set; }

        public static void updateAllListeners(Status s)
        {
            if (Listeners != null)
            {
                foreach (StatusListeners sl in Listeners)
                {
                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => sl.updateStatus(s)));
                }
            }
        }
        public static void registerListener(StatusListeners sl)
        {
            if (Listeners == null)
            {
                Listeners = new List<StatusListeners>();
                UpdateTimer = new DispatcherTimer();
                UpdateTimer.Interval=new TimeSpan(0,0,0,0,1000);
                UpdateTimer.Tick+=UpdateTimer_Tick;
                UpdateTimer.Start();
            }
            if (!Listeners.Contains(sl))
                Listeners.Add(sl);
        }
        
        static void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //API api = API.getInstance();
           //api.updateStatus();
        }

    }


}
