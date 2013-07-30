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
using System.Collections.Generic;

using System.Text;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;
using Microsoft.Phone;
using System.IO;
using Microsoft.Phone.Tasks;

namespace Eye
{
    public partial class MainPage : PhoneApplicationPage
    {

          //create database

        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";
 
            
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           
            Loaded += new RoutedEventHandler(MainPage_Loaded);
         

            // Set the data context of the listbox control to the sample data
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                if (Empdb.DatabaseExists() == false)
                {
                    Empdb.CreateDatabase();
                  
                }

               
            }
            
         
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {

                int a = Empdb.Employees.Count();
               
                if (a == 0)
                {
                  
                    {
                        Employee newEmployee = new Employee
                        {
                            EmployeeID = 1,
                            EmployeeAge = "Age",
                            EmployeeName = "Your Name",
                            NearVision = "----",
                            color = "----",
                            Contrast= "----"
                           

                         
                        };

                        Empdb.Employees.InsertOnSubmit(newEmployee);
                        Empdb.SubmitChanges();
                    }
                }
                else 
                {
                    IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                
                    Employee EmpRemove = EmpQuery.FirstOrDefault();
                      name.Text = EmpRemove.EmployeeName;
                      age.Text = EmpRemove.EmployeeAge;
                     near.Text = EmpRemove.NearVision;
                     color.Text = EmpRemove.color;
                     contrast.Text = EmpRemove.Contrast;
                      
                }
                
            }
           
           /* using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                if(myIsolatedStorage.FileExists("image1.jpg"))
                {

                    this.ReadFromIsolatedStorage("image1.jpg");
                }
                
            }*/

        }



        private void ReadFromIsolatedStorage(string fileName)
        {
            WriteableBitmap bitmap = new WriteableBitmap(200, 200);
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
               
                using (IsolatedStorageFileStream fileStream = myIsolatedStorage.OpenFile(fileName, FileMode.Open, FileAccess.Read))
                {
                    // Decode the JPEG stream.
                    bitmap = PictureDecoder.DecodeJpeg(fileStream);
                }
            }
            this.img.Source = bitmap;
        }
        // Load data for the ViewModel Items

        List<int> saad = new List<int>();

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        
         
          
        }
        
        public IList<Employee> GetEmployeeList()
        {
          return  App.EmployeeViewModel.GetEmployeeList();
        }

        private void E1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else 
            {
                NavigationService.Navigate(new Uri("/Views/PivotPage1.xaml", UriKind.Relative));
            }
        }

 
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            String parameter;
            base.OnNavigatedTo(e);
            
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                name.Text = EmpRemove.EmployeeName;
                age.Text = EmpRemove.EmployeeAge;
               near.Text = EmpRemove.NearVision;
               color.Text = EmpRemove.color;
               contrast.Text = EmpRemove.Contrast;
               
                 }
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                if (myIsolatedStorage.FileExists("image1.jpg"))
                {

                    this.ReadFromIsolatedStorage("image1.jpg");
                }

            }
            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                if (parameter.Equals("true")) 
                {
                    checkBox1.IsChecked = true;
                }
            }
        }

        private void E2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else
            {

                NavigationService.Navigate(new Uri("/Views/Acuity.xaml", UriKind.Relative));
            
            }
        }

        private void E3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/Views/Color1.xaml", UriKind.Relative));
          
            }
        }

        private void E4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/Views/CT.xaml", UriKind.Relative));
            }
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else
            {

                NavigationService.Navigate(new Uri("/Views/Page1.xaml", UriKind.Relative));

            }

        }

        private void Panorama_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("//Current.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://vision.zeiss.com/worldwide/en_de/home.html"
            };

            task.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {  var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://www.merge.com/Solutions/Interoperability.aspx"
            };

            task.Show();
         }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://www.clearcaresolution.com/"
            };

            task.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://www.sauflon.com/sauflon-eye-care-professionals.html"
            };

            task.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://www.mobileeyecaresolutions.com/"
            };

            task.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var task = new Microsoft.Phone.Tasks.WebBrowserTask
            {
                URL = "http://www.amo-inc.com/products/corneal/multi-purpose-solution/complete-multi-purpose-solution-easy-rub-formula"
            };

            task.Show();
        }

        private void ApplicationBarIconButton_Click_3(object sender, EventArgs e)
        {
            MarketplaceReviewTask a = new MarketplaceReviewTask();
            a.Show();
        }

        private void ApplicationBarIconButton_Click_4(object sender, EventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click_5(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

       

        private void button2_Copy_Click_1(object sender, RoutedEventArgs e)
        {


            if (checkBox1.IsChecked == false)
            {
                NavigationService.Navigate(new Uri("/Views/PanoramaPage1.xaml", UriKind.Relative));
            }
            else
            {

                NavigationService.Navigate(new Uri("/Views/Acuity.xaml", UriKind.Relative));

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                EmailComposeTask emailComposeTask = new EmailComposeTask();
                emailComposeTask.To = "";
                emailComposeTask.Subject = "Full Repport";
                emailComposeTask.Body = "Report : \n" + "Name : " +

                EmpRemove.EmployeeName + "\nAge: " +
                EmpRemove.EmployeeAge + "\nNear Vision: " +
                EmpRemove.NearVision + "\nColor: " +
                EmpRemove.color + "\nContrast: " +
                EmpRemove.Contrast;
                emailComposeTask.Show();

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                EmailComposeTask emailComposeTask = new EmailComposeTask();
                emailComposeTask.To = "";
                emailComposeTask.Subject = "Full Repport";
                emailComposeTask.Body = "Report : \n" + "Name : " +

                EmpRemove.EmployeeName + "\nAge: " +
                EmpRemove.EmployeeAge + "\nContrast: " +
                EmpRemove.Contrast;
                emailComposeTask.Show();

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                EmailComposeTask emailComposeTask = new EmailComposeTask();
                emailComposeTask.To = "";
                emailComposeTask.Subject = "Full Repport";
                emailComposeTask.Body = "Report : \n" + "Name : " +

                EmpRemove.EmployeeName + "\nAge: " +
                EmpRemove.EmployeeAge + "\nNear Vision: " +
                EmpRemove.NearVision;
                emailComposeTask.Show();

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                EmailComposeTask emailComposeTask = new EmailComposeTask();
                emailComposeTask.To = "";
                emailComposeTask.Subject = "Full Repport";
                emailComposeTask.Body = "Report : \n" + "Name : " +

                EmpRemove.EmployeeName + "\nAge: " +
                EmpRemove.EmployeeAge + "\nColor: " +
                EmpRemove.color;
                emailComposeTask.Show();

            }
        }


       
    }
}