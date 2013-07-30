using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Eye
{
    public partial class AResult : PhoneApplicationPage
    {
        public AResult()
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
        }

        DateTime now = DateTime.Now;
        DateTime dateTime = DateTime.UtcNow.Date;
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (cb.IsChecked == false)
            {
                using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
                {
                    Employee newEmployee = new Employee
                    {
                        EmployeeID = 300,
                        EmployeeAge = "Test   Set: " + dateTime.ToString("dd/MM"),
                        EmployeeName = "Vision Acuity!"
                    };

                    Empdb.Employees.InsertOnSubmit(newEmployee);
                    Empdb.SubmitChanges();
                    MessageBox.Show("Advisor Set");
                }
                NavigationService.Navigate(new Uri("//MainPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Already Set!");
            }
        }
    }
}