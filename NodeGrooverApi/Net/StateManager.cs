using NodeGrooverClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace NodeGrooverClient.Net
{
    public interface StateManager
    {
        public static List<StatusListeners> Listeners { get; set; }
        public static void updateAllListeners(Status s);
        public static void registerListener(StatusListeners sl);
        
    }


}
