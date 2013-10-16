using NodeGrooverClient.Model;
using NodeGrooverClient.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NowPlaying.xaml
    /// </summary>
    public partial class NowPlaying : UserControl, ISwitchable, StatusListeners
    {
       
        public NowPlaying()
        {
            InitializeComponent();
            TabsViewer.selectButton(1);
            StateManager.registerListener(this);
          
            
        }

        public void UtilizeState(object state)
        {
            
            throw new NotImplementedException();
        }

        public void updateStatus(Model.Status s)
        {
   
        }
    }
}
