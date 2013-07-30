using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TrialApp.Resources;
using Windows.Phone.Speech.Recognition;

namespace TrialApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

       async private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SpeechRecognizerUI speechRecognizer = new SpeechRecognizerUI();
            speechRecognizer.Settings.ListenText = "Go Left or Right?";
            speechRecognizer.Settings.ExampleText = "Examples you can use are: left, right";

            speechRecognizer.Settings.ReadoutEnabled = true;
            speechRecognizer.Settings.ShowConfirmation = true;

            speechRecognizer.Recognizer.Grammars.AddGrammarFromList("answer",
              new string[] { "left", "right" });

            SpeechRecognitionUIResult result = await speechRecognizer.RecognizeWithUIAsync();
            if (result.ResultStatus == SpeechRecognitionUIStatus.Succeeded)
            {
                MessageBox.Show(result.RecognitionResult.Text);
            }
            
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