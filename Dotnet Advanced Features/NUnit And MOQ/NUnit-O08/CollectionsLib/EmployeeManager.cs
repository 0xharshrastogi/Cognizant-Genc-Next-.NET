using System;
using System.Collections.Generic;

namespace CollectionsLib
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }

    public class EmployeeManager
    {
        private static readonly List<Employee> employees;

        static EmployeeManager()
        {
            employees = new List<Employee>
            {
                new Employee { EmpId=100, EmpName="John",DOJ=DateTime.Now.AddYears(-5),Salary=30000},
                new Employee { EmpId=101, EmpName="Mary",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=102, EmpName="Steve",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=103, EmpName="Allen",DOJ=DateTime.Now.AddYears(-7),Salary=50000},
            };
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return employees.FindAll(x => x.DOJ < DateTime.Now);
        }
    }
}
