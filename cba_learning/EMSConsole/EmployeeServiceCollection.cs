using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSConsole
{
    class EmployeeServiceCollection : IEmployeeSvc
    {
        // EMSConsole.EmployeeServiceCollection

        List<Employee> empList = new List<Employee>();

        public EmployeeServiceCollection()
        {
            empList.Add(new Employee(1, "vijay", 12));
            empList.Add(new Employee(2, "jai", 13));
            empList.Add(new Employee(3, "bob", 14));
            empList.Add(new Employee(4, "dave", 15));
        }

        public void CreateEmployee(Employee newEmp)
        {
            empList.Add(newEmp);
        }

        public void DeleteEmployee(int empId)
        {
            Employee delEmp = empList.Find( e => e.EmpId == empId);
            if(delEmp != null)
                empList.Remove(delEmp);
        }

        public void ReadEmployee(int empId)
        {
            Employee findEmp = empList.Find(e => e.EmpId == empId);
            if (findEmp != null)
                Console.WriteLine("Emp Name: " + findEmp.Name + ":ID: " + findEmp.EmpId);

        }

        public void UpdateEmployee(int empId, int age)
        {
            Employee findEmp = empList.Find(e => e.EmpId == empId);
            if (findEmp != null)
                findEmp.Age = age;

        }
    }
}
