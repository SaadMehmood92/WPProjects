using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Greete_Bott
{
    public partial class Profile : PhoneApplicationPage
    {
        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";

        public Profile()
        {
            InitializeComponent();
        
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees where Emp.EmployeeID == 1 select Emp;
                Employee EmpRemove = EmpQuery.FirstOrDefault();
                EmpRemove.EmployeeName = name.Text;
                EmpRemove.EmployeeAge = Age.Text;
                Empdb.SubmitChanges();
                MessageBox.Show("Profile Updated!");
            }
        }
    }
}