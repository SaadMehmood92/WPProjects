
using System.Data.Linq;

namespace Greete_Bott
{
    class EmployeeDataContext : DataContext 
    {
        public EmployeeDataContext(string connectionString)
            : base(connectionString)
        {
        }
        public Table<Employee> Employees
        {
            get
            {
                return this.GetTable<Employee>();
            }
        }
    }
}
