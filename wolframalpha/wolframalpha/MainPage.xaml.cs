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

namespace wolframalpha
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           
        string url = "http://m.wolframalpha.com";
            webbrowser.IsScriptEnabled = true;
            webbrowser.Visibility = Visibility.Visible;
            webbrowser.Navigate (new Uri(url.ToString(),UriKind.Absolute));
        }

        

       
    }
}