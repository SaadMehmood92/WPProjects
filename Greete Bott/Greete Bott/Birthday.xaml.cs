﻿       using System; using System.Collections.Generic; using System.Linq; using System.Net; using System.Windows; using System.Windows.Controls; using System.Windows.Documents; using System.Windows.Input; using System.Windows.Media; using System.Windows.Media.Animation; using System.Windows.Shapes; using Microsoft.Phone.Controls;  namespace Greete_Bott {     public partial class Birthday : PhoneApplicationPage
    {
        public Birthday()
        {
            InitializeComponent();
        }

        private void Option1_Tap(object sender, GestureEventArgs e)
        {
            this.Option1Viewer.Visibility = System.Windows.Visibility.Visible;
            this.Option1Arrow.Visibility = System.Windows.Visibility.Visible;
            this.Option2Viewer.Visibility = System.Windows.Visibility.Collapsed;
            this.Option2Arrow.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Option2_Tap(object sender, GestureEventArgs e)
        {
            this.Option1Viewer.Visibility = System.Windows.Visibility.Collapsed;
            this.Option1Arrow.Visibility = System.Windows.Visibility.Collapsed;
            this.Option2Viewer.Visibility = System.Windows.Visibility.Visible;
            this.Option2Arrow.Visibility = System.Windows.Visibility.Visible;
        }
    } } 