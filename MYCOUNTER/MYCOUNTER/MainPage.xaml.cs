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
using Microsoft.Phone.Tasks;

namespace MYCOUNTER
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            count.Text = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = count.Text;
            int aa = Convert.ToInt32(a);
            aa++;
            count.Text = "" + aa;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = count.Text;
            int aa = Convert.ToInt32(a);

            if (aa > 0)
            {
                aa--;
            }
            else 
            {
                MessageBox.Show("Count less then 1");
            }
            count.Text = "" + aa;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            count.Text = "0";
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            MarketplaceReviewTask a = new MarketplaceReviewTask();
            a.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ShareStatusTask a = new ShareStatusTask();
            a.Status = "Hey my count is " + count.Text + " via MYCOUNTER-WindowsPhone ";
            a.Show();
        }
    }
}