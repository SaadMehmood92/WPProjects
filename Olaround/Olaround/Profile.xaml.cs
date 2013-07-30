using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Olaround
{
    public partial class Profile : PhoneApplicationPage
    {
        public Profile()
        {
            InitializeComponent();
            pano.SelectionChanged += pano_SelectionChanged;
        }

        void pano_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pano.SelectedItem == MyPanoItem) 
            {
                ApplicationBar.IsVisible = true;
            }    
            else
            {
                ApplicationBar.IsVisible = false;
            }
        }

        private void appbarbutton2_Click_1(object sender, EventArgs e)
        {

        }

        private void appbarbutton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}