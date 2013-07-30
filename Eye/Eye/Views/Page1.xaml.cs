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
    public partial class Page1 : PhoneApplicationPage
    {
        String result;
        String sugg;
        public Page1()
        {
            InitializeComponent();
        }
        int key = 1;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                if (key > 11)
                {
           
            {
                result = "20/20";
                sugg = "Optimal Vision!"; ;
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }        return;

                }

                BitmapImage a1 = new BitmapImage(new Uri("/Images/1.PNG", UriKind.Relative));
                BitmapImage a2 = new BitmapImage(new Uri("/Images/2.PNG", UriKind.Relative));
                BitmapImage a3 = new BitmapImage(new Uri("/Images/3.PNG", UriKind.Relative));
                BitmapImage a4 = new BitmapImage(new Uri("/Images/4.PNG", UriKind.Relative));
                BitmapImage a5 = new BitmapImage(new Uri("/Images/5.PNG", UriKind.Relative));
                BitmapImage a6 = new BitmapImage(new Uri("/Images/6.PNG", UriKind.Relative));
                BitmapImage a7 = new BitmapImage(new Uri("/Images/7.PNG", UriKind.Relative));
                BitmapImage a8 = new BitmapImage(new Uri("/Images/8.PNG", UriKind.Relative));
                BitmapImage a9 = new BitmapImage(new Uri("/Images/9.PNG", UriKind.Relative));
                BitmapImage a10= new BitmapImage(new Uri("/Images/10.PNG", UriKind.Relative));
                BitmapImage a11 = new BitmapImage(new Uri("/Images/11.PNG", UriKind.Relative));


                image1.Source = new BitmapImage(new Uri("/Images/" + key + ".PNG", UriKind.Relative));
                key++;

            }
        }

       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (key == 2) 
            {
                result = "Below 20/400";
                sugg = "Poor Vision !";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));
            }
            if (key == 3) 
            {
                result = "20/400";
                sugg = "Poor Vision !";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));
            
            }
            if (key == 4)
            {
                result = "20/200";
                sugg = "You are considered as blind !";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 5)
            {
                result = "20/100";
                sugg = "Hardly see 20 ft far things, see your doctor!";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 6)
            {
                result = "20/80";
                sugg = "Find Vision Solution soon !";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 7)
            {
                result = "20/60";
                sugg = "wear glasses regularly and consult doctor!";
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 8)
            {
                result = "20/50";
                sugg = "wear glasses regularly and consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 9)
            {
                result = "20/40";
                sugg = "wear glasses regularly and consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 10)
            {
                result = "20/30";
                sugg = "wear glasses regularly and do some exercises!"; ;
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            if (key == 11)
            {
                result = "20/25";
                sugg = "Optimal Vision, but do consult doctor!"; ;
                NavigationService.Navigate(new Uri("/Views/Result.xaml?parameter=" + result + "&parameter2=" + sugg, UriKind.Relative));

            }
            





        }
    }
}