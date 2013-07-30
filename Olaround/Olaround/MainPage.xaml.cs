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

namespace Olaround
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Facebook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FacebookLogin.xaml", UriKind.Relative));
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SignUp.xaml", UriKind.Relative));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }

        private void btnSignUp_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}