using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace MYCOUNTER
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmailComposeTask a = new EmailComposeTask();
            a.To = "saad-mehmood@outlook.com";
            a.Subject = "Review/Suggestion MY COUNTER";
                a.Show();
        }
    }
}