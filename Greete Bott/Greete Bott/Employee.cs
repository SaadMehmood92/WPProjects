﻿
using System.Data.Linq.Mapping;

namespace Greete_Bott
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
        [Column(CanBeNull = false)]
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
    }
}
