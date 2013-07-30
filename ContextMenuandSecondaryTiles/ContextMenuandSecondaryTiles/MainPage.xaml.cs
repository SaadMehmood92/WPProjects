using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
namespace ContextMenuandSecondaryTiles
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void menuItem1_Click_1(object sender, RoutedEventArgs e)
        {
            StandardTileData secondarytille = new StandardTileData
            {
                Title = "Bulletins",

            };
            ShellTile.Create(new Uri("/MainPage.xaml", UriKind.Relative), secondarytille);

            ConnectionSettingsTask task = new ConnectionSettingsTask();
            task.ConnectionSettingsType = ConnectionSettingsType.WiFi;
            task.Show();
        }


    }
}