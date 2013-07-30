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
    public partial class CTR : PhoneApplicationPage
    {
        public CTR()
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
                sugg1.Text = parameter1;
            }
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
            
                
                 EmpRemove.Contrast = res.Text;
                Empdb.SubmitChanges();
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
                        EmployeeID = 752,
                        EmployeeAge = "Test   Set: " + dateTime.ToString("dd/MM"),
                        EmployeeName = "Contrast Vision!"
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

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {

            ShareStatusTask shareStatusTask = new ShareStatusTask();//same name
            shareStatusTask.Status = "My Contrast Test Result is : " + res.Text  + "\n via EYECARE";
            shareStatusTask.Show();
        }
      
    }
}