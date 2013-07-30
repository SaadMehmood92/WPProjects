using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;
using Microsoft.Phone;
using System.IO;

namespace Eye
{
    public partial class Current : PhoneApplicationPage
    {
        public Current()
        {
            InitializeComponent();

           
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                if (myIsolatedStorage.FileExists("image1.jpg"))
                {

                    this.ReadFromIsolatedStorage("image1.jpg");
                }

            }
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("//Profile.xaml", UriKind.Relative));
        }
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";

      
        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
              IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                name.Text = EmpRemove.EmployeeName;
                age.Text = EmpRemove.EmployeeAge;
                Empdb.SubmitChanges();
         }
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                if (myIsolatedStorage.FileExists("image1.jpg"))
                {

                    this.ReadFromIsolatedStorage("image1.jpg");
                }

            }

        }
       
    }
}