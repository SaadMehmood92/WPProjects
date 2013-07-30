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

namespace huh
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void abc_Click(object sender, RoutedEventArgs e)
        {

           
            
            dotnet.DotnetDailyFactSoapClient dotnet = new dotnet.DotnetDailyFactSoapClient();
            dotnet.GetDotnetDailyFactAsync();
            dotnet.GetDotnetDailyFactCompleted += dotnet_GetDotnetDailyFactCompleted;
        }

        void dotnet_GetDotnetDailyFactCompleted(object sender, dotnet.GetDotnetDailyFactCompletedEventArgs e)
        {
           asd.Text  = e.Result;
        }

       

        }
    }
