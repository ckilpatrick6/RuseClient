using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string host = hostBox.Text;
            int port = int.Parse(portBox.Text);

            NodeGrooverClient.Properties.Settings.Default.Properties["Host"].DefaultValue = host;
            NodeGrooverClient.Properties.Settings.Default.Properties["Port"].DefaultValue = port;
            NodeGrooverClient.Properties.Settings.Default.Save(); 
            API.getInstance().changeHost();
        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
            hostBox.Text = NodeGrooverClient.Properties.Settings.Default.Properties["Host"].DefaultValue.ToString();
            portBox.Text = NodeGrooverClient.Properties.Settings.Default.Properties["Port"].DefaultValue.ToString();
        }
    }
}
