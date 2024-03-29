﻿using System;
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

namespace PhoneApp10
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
            ServiceReference1.DotnetDailyFactSoapClient a = new ServiceReference1.DotnetDailyFactSoapClient();
            a.GetDotnetDailyFactCompleted += a_GetDotnetDailyFactCompleted;
            a.GetDotnetDailyFactAsync();
        }

        void a_GetDotnetDailyFactCompleted(object sender, ServiceReference1.GetDotnetDailyFactCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }
    }
}