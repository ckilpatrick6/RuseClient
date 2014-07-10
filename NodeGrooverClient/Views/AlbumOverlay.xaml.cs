using Framework.UI.Controls;
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
    /// Interaction logic for AlbumOverlay.xaml
    /// </summary>
    public partial class AlbumOverlay
    {
        public AlbumOverlay()
        {
            InitializeComponent();
        }

        private void CommandButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
