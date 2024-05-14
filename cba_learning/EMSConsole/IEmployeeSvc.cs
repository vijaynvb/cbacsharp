using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSConsole
{
    // system architects
    public interface IEmployeeSvc
    {
        public void CreateEmployee(Employee newEmp);
        public void UpdateEmployee(int empId, int age);
        public void ReadEmployee(int empId);
        public void DeleteEmployee(int empId);
    }
}
