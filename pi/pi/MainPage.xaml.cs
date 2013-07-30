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
using System.Diagnostics;
using Microsoft.Phone.Tasks;

namespace pi
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            device.Text = Environment.OSVersion.ToString();
            tick.Text= Environment.TickCount.ToString();
            model.Text = GetDeviceModel();
            processor.Text = Microsoft.Phone.Info.DeviceStatus.ApplicationCurrentMemoryUsage.ToString();
            one.Text = piCalculation(1000);
            ten.Text = piCalculation(10000);
            hundred.Text = piCalculation(100000);
            thousand.Text = piCalculation(1000000);
            twoTHousand.Text = piCalculation(2000000);
            ttt0.Text = piCalculation(30000000);
            //Shows the rate reminder message, according to the settings of the RateReminder.
            (App.Current as App).rateReminder.Notify();
        }

        public static string GetDeviceModel()  
{  
   string model = null;  
   object theModel = null;  
  
   if (Microsoft.Phone.Info.DeviceExtendedProperties.TryGetValue("DeviceName", out theModel))  
      model = theModel as string;

   return model;
}
        string temp;
        public string piCalculation(int m) 
        {
           
            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
            }
            s1.Stop();
            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
            }
            s2.Stop();
            Stopwatch s3 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
            }
            s3.Stop();
            Stopwatch s4 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
            }
            s4.Stop();
            Stopwatch s5 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
            }
            s5.Stop();
            string result =  String.Format("{0},{1},{2},{3},{4} mSeconds",
                s1.ElapsedMilliseconds,
                s2.ElapsedMilliseconds,
                s3.ElapsedMilliseconds,s4.ElapsedMilliseconds,s5.ElapsedMilliseconds);
            temp = "" + s4.ElapsedMilliseconds;
            return result;
        }
		/// <summary>
        /// Navigates to about page.
        /// </summary>
        private void GoToAbout(object sender, GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/About.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            string device = GetDeviceModel();
            ShareStatusTask task = new ShareStatusTask();
            task.Status = "I am using " + device + " it scored " + temp + " mSeconds   \nvia Pi for WindowsPhone";
            task.Show();
        }
    }
}
