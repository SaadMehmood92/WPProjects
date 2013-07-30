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

using Microsoft.Phone.Controls.Maps;
using System.Device.Location;

namespace MYIP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var rootObject = JsonConvert.DeserializeObject<RootObject>(e.Result);
            _as.Text = rootObject.@as;
           city.Text = rootObject.city;
           country.Text= rootObject.country;
          isp.Text= rootObject.isp;
          reverse.Text = rootObject.reverse;
         query.Text = rootObject.query;
        timezone.Text =  rootObject.timezone;
        regionName.Text = rootObject.regionName;

        double longitude = double.Parse(rootObject.lon);
            double latitude = double.Parse(rootObject.lat);
        //declare the Pushpin 
        Pushpin p = new Pushpin();
        //define it's graphic properties 
        p.Background = new SolidColorBrush(Colors.Yellow);
        p.Foreground = new SolidColorBrush(Colors.Black);
        //where to put the Pushpin 
        p.Location = new GeoCoordinate(latitude,longitude);
        //What to write on it
        p.Content = "IP-Location";
        //now we add the Pushpin to the map
        map1.Children.Add(p);
        map1.SetView(new GeoCoordinate(latitude, longitude), 9); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new Uri("http://ip-api.com/json"));
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new Uri("http://ip-api.com/json/"+iip.Text.Trim()));
        }
    }
}