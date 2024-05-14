using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSConsole
{
    class EmployeeService
    { // CRUD Operations on a Employee list

        Employee[] employees = new Employee[10];

        public void CreateEmployee(Employee newEmp)
        {
            employees[employees.Length - 1] = newEmp;
        }
    }
}
