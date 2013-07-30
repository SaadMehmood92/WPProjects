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

namespace Eye
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml?parameter=true", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Kindly check the checkbox!");
            }
        }
    }
}