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

namespace Greete_Bott
{
    public partial class MainPage : PhoneApplicationPage
    {
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                if (Empdb.DatabaseExists() == false)
                {
                    Empdb.CreateDatabase();
                    MessageBox.Show("Employee Database Created Successfully!!!");
                }
                else
                {
                    MessageBox.Show("Employee Database already exists!!!");
                }
            }
        
            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                if (Empdb.Employees.Count() == 0)
                {
                    Employee newEmployee = new Employee
                    {
                        EmployeeID = 1,
                        EmployeeAge = "Your Age",
                        EmployeeName = "Your Name"
                    };
                    name.Text = newEmployee.EmployeeName;
                    Empdb.Employees.InsertOnSubmit(newEmployee);
                    Empdb.SubmitChanges();
                    
                    MessageBox.Show("Profile Created");
                }
                else 
                {       IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                        Employee EmpRemove = EmpQuery.FirstOrDefault();
                       name.Text =  EmpRemove.EmployeeName ;

                        Empdb.SubmitChanges();
                        MessageBox.Show("Profile Already Exists");
                 
                }

                }
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void RadSlideHubTile_Tap_1(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Birthday.xaml",UriKind.Relative));
        }

        private void RadCustomHubTile_Tap_1(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile.xaml", UriKind.Relative));
       
        }

        //here

        // type it here
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);

            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                name.Text = EmpRemove.EmployeeName;

                Empdb.SubmitChanges();
                MessageBox.Show("Profile Already Exists");
            }    
        }




    }
}