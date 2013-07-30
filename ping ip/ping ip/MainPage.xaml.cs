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
using Newtonsoft.Json;

namespace ping_ip
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            string uri ="http://ip-api.com/json";
            webClient.DownloadStringAsync(new Uri(string.Format(uri)));
            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;
           
          
        }

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Result)) 
            {
                var root1 = JsonConvert.DeserializeObject<RootObject>(e.Result);
                this.DataContext = root1;

            }
        }

     
    }
}