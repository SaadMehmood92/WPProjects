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

namespace Olaround
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            mainPivot.LoadingPivotItem += mainPivot_LoadingPivotItem;

            // create some text, and add it to the paragraph


            Hyperlink lnkSSLink1 = new Hyperlink();

            lnkSSLink1.Inlines.Add("claim now ►");
            lnkSSLink1.NavigateUri = new Uri("http://yoururl");// your URL must be placed here
            para1.Inlines.Add(lnkSSLink1);

            // create a link, and add it
            Hyperlink lnkSSLink = new Hyperlink();
           
            lnkSSLink.Inlines.Add("view on map ►");
            lnkSSLink.NavigateUri = new Uri("http://yoururl");// your URL must be placed here
            para.Inlines.Add(lnkSSLink);

            Hyperlink rtbPhoneNumberHyperLink = new Hyperlink();

            rtbPhoneNumberHyperLink.Inlines.Add("+92-331-4939703");
            rtbPhoneNumberHyperLink.NavigateUri = new Uri("http://yoururl");// your URL must be placed here
            parPhone.Inlines.Add(rtbPhoneNumberHyperLink);

         
        }

        void mainPivot_LoadingPivotItem(object sender, PivotItemEventArgs e)
        {
            if (e.Item == myPivotItem)
                ApplicationBar.IsVisible = false;
            else
                ApplicationBar.IsVisible = true;
        }

     
    }
}