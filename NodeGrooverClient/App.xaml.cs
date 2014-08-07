using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NodeGrooverClient.Properties;

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
            _api = new Api(Settings.Default["endpoint"].ToString());
        } 
        public void changeUri(string uri)
        {
            _api.disconnect();
            Settings.Default["endpoint"] = uri;
            Settings.Default.Save();
            _api = new Api(uri);
        }
        private void StartupHandler(object sender, System.Windows.StartupEventArgs e)
        {
            //Elysium.Manager.Apply(this, Elysium.Theme.Dark, Elysium.AccentBrushes.Green, Elysium.AccentBrushes.Lime);
        }
    }
}
