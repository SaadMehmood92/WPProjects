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

namespace Eye
{
    public partial class Result : PhoneApplicationPage
    {
        String pp;
        public Result()
        {
            
            InitializeComponent();
          
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string parameter = string.Empty;

            string parameter1 = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                res.Text = parameter;
            }
            if (NavigationContext.QueryString.TryGetValue("parameter2", out parameter1))
            {
                sugg.Text = parameter1;
            }
            using (EmployeeDataContext context = new EmployeeDataContext(strConnectionString))
            {
                // find a city to update
                IQueryable<Employee> cityQuery = from c in context.Employees where c.EmployeeID == 1 select c;
                Employee cityToUpdate = cityQuery.FirstOrDefault();

                // update the city by changing its name
               
                cityToUpdate.NearVision = res.Text;

                // save changes to the database
                context.SubmitChanges();
            }
        }
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";
        DateTime now = DateTime.Now;
        DateTime dateTime = DateTime.UtcNow.Date;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (cb.IsChecked == false)
            {
                using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
                {
                    Employee newEmployee = new Employee
                    {
                        EmployeeID = 100,
                        EmployeeAge = "Check up  Set: " + dateTime.ToString("dd/MM"),
                        EmployeeName = "Near Vision!"
                    };

                    Empdb.Employees.InsertOnSubmit(newEmployee);
                    Empdb.SubmitChanges();
                    MessageBox.Show("Advisor Set");
                    cb.IsChecked = true;
                }

                NavigationService.Navigate(new Uri("//MainPage.xaml", UriKind.Relative));
            }
            else{
                MessageBox.Show("Already Set!");
            }
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            ShareStatusTask shareStatusTask = new ShareStatusTask();//same name
            shareStatusTask.Status = "My Near Vision is : " + res.Text + "Rx" + "\n via EYECARE";
                shareStatusTask.Show();
             
        }
    }
}