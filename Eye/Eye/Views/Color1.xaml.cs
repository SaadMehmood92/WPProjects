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
    public partial class Color1 : PhoneApplicationPage
    {
        public Color1()
        {
            InitializeComponent();
        }
        int key = 1;

        String result;
        String Comments;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (key > 7)
            {
                
                {
                    result = "Optimal";
                    Comments = "Your perfectly see colors.";
                    NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
                }
                return;

            }

          
            Foo.Source = new BitmapImage(new Uri("/Images/CC" + key + ".PNG", UriKind.Relative));
            key++;

            
            
        }
        private void Button_Click_2(object sender, RoutedEventArgs e) 
        {
           
            if (key == 2) 
            {
                result = "Color Blind";
                Comments = "Plan a meeting with doctor";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
            if (key == 3)
            {
                result = "Color Blind";
                Comments = "Plan a meeting with doctor";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
            if (key == 4)
            {
                result = "Serious";
                Comments = "Plan a meeting with doctor";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));

            }
            if (key == 5)
            {
                result = "Warning";
                Comments = "Plan a meeting with doctor";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
            if (key == 6)
            {
                result = "Normal";
                Comments = "Your see colors good";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
            if (key == 7)
            {
                result = "Normal";
                Comments = "Your see colors good";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
            if (key == 8)
            {
                result = "Normal";
                Comments = "Your see colors good";
                NavigationService.Navigate(new Uri("/Views/CResult.xaml?parameter=" + result + "&parameter2=" + Comments, UriKind.Relative));
            }
        }
    }
}
    
