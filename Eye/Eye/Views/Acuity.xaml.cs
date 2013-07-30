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
    public partial class Acuity : PhoneApplicationPage
    {
        public Acuity()
        {
            InitializeComponent();
        }
        int key = 1;
        String result;
        String sugg;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                if (key > 11)
                {

                    {
                        result = "Optimal";
                        sugg = "Optimal Vision!"; ;
                        NavigationService.Navigate(new Uri("/Views/AResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

                    } return;

                }

                

                image1.Source = new BitmapImage(new Uri("/Images/" + key + ".PNG", UriKind.Relative));
                key++;

            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (key == 2)
            {
                result = "Poor";
                sugg = "Blind you are !";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));
            }
            if (key == 3)
            {
                result = "Poor";
                sugg = "Poor Vision !";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 4)
            {
                result = "Poor";
                sugg = "You are considered as blind !";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 5)
            {
                result = "Hardly See";
                sugg = "Hardly see 20 ft far things, see your doctor!";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 6)
            {
                result = "Effected Vision";
                sugg = "Find Vision Solution soon !";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 7)
            {
                result = "Normal";
                sugg = "wear glasses regularly and consult doctor!";
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 8)
            {
                result = "Normal";
                sugg = "wear glasses regularly and consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 9)
            {
                result = "Good";
                sugg = "wear glasses regularly and consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 10)
            {
                result = "Good";
                sugg = "wear glasses regularly and do some exercises!"; ;
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 11)
            {
                result = "Optimal";
                sugg = "Optimal Vision, but do consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/ACResult.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }






        }

        
    }
}