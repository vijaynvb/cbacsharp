using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMSConsole
{
    // EMSConsole.EmployeeService

    // service class 
    class EmployeeService : IEmployeeSvc
    { // CRUD Operations on a Employee list

        public EmployeeService()
        {

        }
        public EmployeeService(string str)
        {

        }


        // arrays
        Employee[] employees = new Employee[10];

        public void CreateEmployee(Employee newEmp)
        {
            employees[newEmp.EmpId - 1] = newEmp;
        }
        public void UpdateEmployee(int empId, int age)
        {
            // find the mepid update the age 
            employees[empId - 1].Age = age;
        }
        public void ReadEmployee(int empId)
        {
            Console.WriteLine(employees[empId - 1].Name + " : " + employees[empId - 1].Age);
        }
        public void DeleteEmployee(int empId)
        {
            employees[empId - 1] = null;
        }
    }
}
