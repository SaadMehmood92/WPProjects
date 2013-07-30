using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace Eye
{
    public partial class CT : PhoneApplicationPage
    {
        public CT()
        {
            InitializeComponent();
        }
        String sugg;
        String result;
        int key = 1;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (key > 6) 
            {
{
                    result = "Optimal";
                    sugg = "Optimal Contrast!";
                    NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));
                }
            }
            Foo.Source = new BitmapImage(new Uri("/Images/C" + key + ".PNG", UriKind.Relative));
            key++;
        }
     
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (key == 2)
            {
                result = "Poor";
                sugg = "Poor Contrast !";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));
            }
            if (key == 3)
            {
                result = "Poor";
                sugg = "Poor Contrast !";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 4)
            {
                result = "Normal";
                sugg = "You are considered as Normal !";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 5)
            {
                result = "Normal";
                sugg = "You are considered as Normal";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 6)
            {
                result = "Optimal";
                sugg = "Optimal Contrast";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 7)
            {
                result = "Normal";
                sugg = "wear glasses regularly and consult doctor!";
                NavigationService.Navigate(new Uri("/Views/CTR.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            
        }
    }
}