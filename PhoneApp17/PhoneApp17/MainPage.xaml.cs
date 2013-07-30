       using System; using System.Collections.Generic; using System.Linq; using System.Net; using System.Windows; using System.Windows.Controls; using System.Windows.Documents; using System.Windows.Input; using System.Windows.Media; using System.Windows.Media.Animation; using System.Windows.Shapes; using Microsoft.Phone.Controls;  namespace PhoneApp17 {     public partial class MainPage : PhoneApplicationPage     {         public MainPage()         {             InitializeComponent();         }

        private void tile_tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void graph_tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Graph.xaml", UriKind.Relative));
        
        }     } } 