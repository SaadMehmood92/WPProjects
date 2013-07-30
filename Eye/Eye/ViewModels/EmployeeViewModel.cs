using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Eye.ViewModels
{
    public class EmployeeViewModel
    {

        private const string strConnectionString = @"isostore:/EmployeeDB.sdf";
        public IList<Employee> GetEmployeeList()
        {
            // Fetching data from local database
            IList<Employee> EmployeeList = null;

            using (EmployeeDataContext Empdb = new EmployeeDataContext(strConnectionString))
            {
                IQueryable<Employee> EmpQuery = from Emp in Empdb.Employees select Emp;
                EmployeeList = EmpQuery.ToList();
            }
            return EmployeeList;
        }

    }
}
