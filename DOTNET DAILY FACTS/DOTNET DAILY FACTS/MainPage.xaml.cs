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
using System.Xml.Linq;

namespace DOTNET_DAILY_FACTS
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
         InitializeComponent();

    WebClient myRSS = new WebClient();
    myRSS.DownloadStringCompleted += new DownloadStringCompletedEventHandler(myRSS_DownloadStringCompleted);

    //Read Async
    myRSS.DownloadStringAsync(new Uri(@"http://feeds.feedburner.com/dailydotnettips/MvvJ?format=xml"));

        }
        void myRSS_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
{
    //Check if the Network is available
    try
    {
        if (Microsoft.Phone.Net.NetworkInformation.DeviceNetworkInformation.IsNetworkAvailable)
        {
            var rssData = from rss in XElement.Parse(e.Result).Descendants("item")
                          select new RSSClass
                          {
                              Title = rss.Element("title").Value,
                              PubDate = rss.Element("pubDate").Value
                          };
            lstRSS.ItemsSource = rssData;
        }
        else
        {
            MessageBox.Show("No network is available..");
        }
    }
    catch (Exception eee) 
    {
        MessageBox.Show(eee.Message);
    }
}
 
    
    
    
    }

 
    public class RSSClass
    {
        public string Title { get; set; }
        public string PubDate { get; set; }
    }

}
