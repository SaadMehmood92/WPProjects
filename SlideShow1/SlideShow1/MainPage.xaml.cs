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
using System.Windows.Media.Imaging;

namespace SlideShow1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            List<BitmapImage> imgg = null;
            imgg.Add(new BitmapImage(new Uri("/1.png",UriKind.Relative)));
            imgg.Add(new BitmapImage(new Uri("/2.png", UriKind.Relative)));
            imgg.Add(new BitmapImage(new Uri("/3.png", UriKind.Relative)));

            hello.ItemsSource = imgg;
        }
    }
}