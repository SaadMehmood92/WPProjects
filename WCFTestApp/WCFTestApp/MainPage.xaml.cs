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

namespace WCFTestApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            ServiceReference2.Service1SoapClient obj = new ServiceReference2.Service1SoapClient();
            obj.UTCTimeAsync();
            obj.UTCTimeCompleted += obj_UTCTimeCompleted;
            obj.DailyrainAsync();
            obj.DailyrainCompleted += obj_DailyrainCompleted;
        }

      

        void obj_DailyrainCompleted(object sender, ServiceReference2.DailyrainCompletedEventArgs e)
        {
            tex.Text = e.Result;
        }

        void obj_UTCTimeCompleted(object sender, ServiceReference2.UTCTimeCompletedEventArgs e)
        {
            tex.Text = e.Result;
        }

       

        //method after completion of event! other wise be ready for errors
        
     

        
    }
}