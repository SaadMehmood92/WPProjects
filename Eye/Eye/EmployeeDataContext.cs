using System.Data.Linq;

namespace Eye
{
    public class EmployeeDataContext : DataContext
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
