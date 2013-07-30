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
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Phone;

namespace Eye
{
    public partial class Profile : PhoneApplicationPage
    {
        public Profile()
        {
            InitializeComponent();

          
          
        }

        PhotoChooserTask photoChooserTask;

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
        String source;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {

                if (myIsolatedStorage.FileExists("image1.jpg"))
                {

                    this.ReadFromIsolatedStorage("image1.jpg");
                }

            }
        }
        private void photoChooserTask_Completed(object sender, PhotoResult e)
        {
          
            BitmapImage image = new BitmapImage();
            image.SetSource(e.ChosenPhoto);
            source = e.OriginalFileName.ToString();
            this.img.Source = image;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowCameraCaptureTask();
        }
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";
        Random rn = new Random();
        private void ShowCameraCaptureTask()
        {
            CameraCaptureTask photoCameraCapture = new CameraCaptureTask();
            photoCameraCapture.Completed += new EventHandler<PhotoResult>(photoCameraCapture_Completed);
            photoCameraCapture.Show();
        }

        void photoCameraCapture_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                SaveToIsolatedStorage(e.ChosenPhoto, "image1.jpg");
            }
            
        }
        private void SaveToIsolatedStorage(Stream imageStream, string fileName)
        {
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (myIsolatedStorage.FileExists(fileName))
                {
                    myIsolatedStorage.DeleteFile(fileName);
                }

                IsolatedStorageFileStream fileStream = myIsolatedStorage.CreateFile(fileName);
                BitmapImage bitmap = new BitmapImage();
                bitmap.SetSource(imageStream);

                WriteableBitmap wb = new WriteableBitmap(bitmap);
                wb.SaveJpeg(fileStream, wb.PixelWidth, wb.PixelHeight, 0, 85);
                fileStream.Close();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (name.Text.Equals("") && age.Text.Equals(""))
            {
                MessageBox.Show("Enter Fields !");

            }
            else
            {
                using (EmployeeDataContext context = new EmployeeDataContext(strConnectionString))
                {
                    // find a city to update
                    IQueryable<Employee> cityQuery = from c in context.Employees where c.EmployeeID == 1 select c;
                    Employee cityToUpdate = cityQuery.FirstOrDefault();

                    // update the city by changing its name
                    cityToUpdate.EmployeeName = name.Text;
                    cityToUpdate.EmployeeAge = age.Text;

                    // save changes to the database
                    context.SubmitChanges();
                }
                MessageBox.Show("Profile Saved!");
                NavigationService.Navigate(new Uri("/Current.xaml", UriKind.Relative));
            }
        }
        public static byte[] ConvertToBytes(String imageLocation)
        {
            StreamResourceInfo sri = Application.GetResourceStream(new Uri(imageLocation, UriKind.RelativeOrAbsolute));
            BinaryReader binary = new BinaryReader(sri.Stream);

            byte[] imgByteArray = binary.ReadBytes((int)(sri.Stream.Length));

            binary.Close();
            binary.Dispose();
            return imgByteArray;
        }
     
    }
}