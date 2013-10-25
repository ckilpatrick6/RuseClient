using Elysium.Controls;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl, StatusListeners
    {
        API api;
        bool playing=false;
       
        public Search()
        {
            InitializeComponent();
            StateManager.registerListener(this);
          
           
        }





        public void updateStatus(Status s)
        {
            //Maybe other things here 
        }

    
        public void UtilizeState(object state)
        {
 	        throw new NotImplementedException();
        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
            //TabsViewer.selectButton(0);
        }
    }
}
