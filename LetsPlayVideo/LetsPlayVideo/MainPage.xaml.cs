﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
namespace LetsPlayVideo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher mediaPlayer = new MediaPlayerLauncher();
            mediaPlayer.Media = new Uri("http://www.dailymotion.com/en/relevance/search/donald+duck/1#video=xzzzk3", UriKind.Absolute);
            mediaPlayer.Show();
        }
    }
}