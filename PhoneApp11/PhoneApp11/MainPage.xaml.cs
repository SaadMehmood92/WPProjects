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

namespace PhoneApp11
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
            ServiceReference1.Service1Client a = new ServiceReference1.Service1Client();
            a.GetDataCompleted += a_GetDataCompleted;
            a.GetDataAsync(5);
        }

        void a_GetDataCompleted(object sender, ServiceReference1.GetDataCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}