using System.Data.Linq.Mapping;
// LINQ to SQL
namespace Eye
{
    [Table]
    public class Employee
    {
        [Column(IsPrimaryKey = true)]
        public int EmployeeID
        {
            get;
            set;
        }

        [Column(CanBeNull = true)]
        public string EmployeeName
        {
            get;
            set;
        }
        [Column(CanBeNull = false)]
        public string EmployeeAge
        {
            get;
            set;
        }
        
        [Column(CanBeNull = true)]
        public string EyeDisease
        {
            get;
            set;
        }

        [Column(CanBeNull = true)]
        public string NearVision
        {
            get;
            set;
        }
        [Column(CanBeNull = true)]
        public string color
        {
            get;
            set;
        }
        [Column(CanBeNull = true)]
        public string Contrast
        {
            get;
            set;
        }
    }

}
