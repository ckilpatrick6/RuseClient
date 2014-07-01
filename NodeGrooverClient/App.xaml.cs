using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NodeGrooverClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Api _api;
        public Api Api { get { return _api; } }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _api = new Api("http://localhost:5000/");
        } 
        private void StartupHandler(object sender, System.Windows.StartupEventArgs e)
        {
            //Elysium.Manager.Apply(this, Elysium.Theme.Dark, Elysium.AccentBrushes.Green, Elysium.AccentBrushes.Lime);
        }
    }
}
