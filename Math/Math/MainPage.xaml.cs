using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Math.Resources;
using System.Windows.Documents;
using System.Windows.Media;

namespace Math
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Paragraph prgParagraph = new Paragraph();

            // create some text, and add it to the paragraph
            Bold bldText = new Bold();
            bldText.Inlines.Add(new Run() { Text = "(x + 1)" });

            Italic itlText = new Italic();
            itlText.Inlines.Add(new Run() { Text = String.Format(" {0,-3}", '\u00B2'), Foreground = new SolidColorBrush(Colors.Yellow) });


            prgParagraph.Inlines.Add(bldText);
           
            prgParagraph.Inlines.Add(itlText);
            prgParagraph.Inlines.Add(new LineBreak());
 
            prgParagraph.Inlines.Add(new LineBreak());
       

            rbtMyRichTextBox.Blocks.Add(prgParagraph);




            MathTB.Text = "(x + 1)";
            MathTB.Text += String.Format(" {0,-3}", '\u00B2');
            MathTB.Text += " = ";
            MathTB.Text += "x";
            MathTB.Text += String.Format(" {0,-3}", '\u00B2');
            MathTB.Text += " + ";
            MathTB.Text += "2x + 1";
 
          

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}