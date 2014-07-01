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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        //public ObservableCollection<SolidColorBrush> accentColors { get; set; }
        //public SolidColorBrush SelectedColor { get; set; }
        //public String SelectedTheme { get; set; }

        //public List<String> Themes { get; set; }
        public Settings()
        {
            InitializeComponent();
            //accentColors = new ObservableCollection<SolidColorBrush>();
            //accentColors.Add(Elysium.AccentBrushes.Blue);
            //accentColors.Add(Elysium.AccentBrushes.Brown);
            //accentColors.Add(Elysium.AccentBrushes.Green);
            //accentColors.Add(Elysium.AccentBrushes.Lime);
            //accentColors.Add(Elysium.AccentBrushes.Magenta);
            //accentColors.Add(Elysium.AccentBrushes.Mango);
            //accentColors.Add(Elysium.AccentBrushes.Orange);
            //accentColors.Add(Elysium.AccentBrushes.Pink);
            //accentColors.Add(Elysium.AccentBrushes.Purple);
            //accentColors.Add(Elysium.AccentBrushes.Red);
            //accentColors.Add(Elysium.AccentBrushes.Rose);
            //accentColors.Add(Elysium.AccentBrushes.Sky);
            //accentColors.Add(Elysium.AccentBrushes.Violet);
            //accentColors.Add(Elysium.AccentBrushes.Viridian);

            //Themes = new List<string>()
            //{
            //    "Light",
            //    "Dark"
            //};



            //DataContext = this;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        //    string host = hostBox.Text;
        //    int port = int.Parse(portBox.Text);

        //    NodeGrooverClient.Properties.Settings.Default.Properties["Host"].DefaultValue = host;
        //    NodeGrooverClient.Properties.Settings.Default.Properties["Port"].DefaultValue = port;
        //    NodeGrooverClient.Properties.Settings.Default.Save(); 
        //    API.getInstance().changeHost();
        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {
        //    hostBox.Text = NodeGrooverClient.Properties.Settings.Default.Properties["Host"].DefaultValue.ToString();
        //    portBox.Text = NodeGrooverClient.Properties.Settings.Default.Properties["Port"].DefaultValue.ToString();
        //    SelectedColor = Elysium.Manager.GetAccentBrush(Application.Current);
        //    SelectedTheme = Elysium.Manager.GetTheme(Application.Current) == Elysium.Theme.Dark ? "Dark" : "Light";
         
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    if(SelectedTheme=="Dark")
        //        Elysium.Manager.Apply(Application.Current, Elysium.Theme.Dark, SelectedColor, Elysium.AccentBrushes.Lime);
        //    else
        //        Elysium.Manager.Apply(Application.Current, Elysium.Theme.Light, SelectedColor, Elysium.AccentBrushes.Lime);
        }

        
    }
}
