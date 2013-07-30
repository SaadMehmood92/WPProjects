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
using System.Xml;

namespace footbal
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ServiceReference1.DotnetDailyFactSoapClient a = new ServiceReference1.DotnetDailyFactSoapClient();
            a.GetDotnetDailyFactAsync();
            a.GetDotnetDailyFactCompleted += a_GetDotnetDailyFactCompleted;
        
        }

        void a_GetDotnetDailyFactCompleted(object sender, ServiceReference1.GetDotnetDailyFactCompletedEventArgs e)
        {
          tb1.Text= e.Result;    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri("http://api.wolframalpha.com/v2/query?input=pi&appid=EPWUJH-X523W335W6"));
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

       

      



        }
}