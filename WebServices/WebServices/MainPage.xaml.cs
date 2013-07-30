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

namespace WebServices
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
            ServiceReference2.PostcodeIT_UKSoapClient a = new ServiceReference2.PostcodeIT_UKSoapClient();
            a.HelloWorldCompleted += a_HelloWorldCompleted;
            a.HelloWorldAsync();
        }

        void a_HelloWorldCompleted(object sender, ServiceReference2.HelloWorldCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

   

        

  

        

    }
}