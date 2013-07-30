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

namespace Context_and_secondary
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void menu1_Click_1(object sender, RoutedEventArgs e)
        {
            StandardTileData secondarytille = new StandardTileData
            {
                Title = "Bulletins",

            };
            ShellTile.Create(new Uri("/MainPage.xaml", UriKind.Relative), secondarytille);

       

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello World");
        }
    }
}