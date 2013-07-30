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
using Microsoft.Phone.Tasks;
namespace PhoneApp18
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new Uri("http://api.drng.dk/create-link.php?url="+input.Text));
        }
        string lau_result = "";
        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var rootObject = JsonConvert.DeserializeObject<RootObject>(e.Result);
            string url = "drng.dk/" + rootObject.id;
            Result.Text=url;

            WebBrowserTask task = new WebBrowserTask();
            task.URL = url;
            task.Show();
        }
    }
}