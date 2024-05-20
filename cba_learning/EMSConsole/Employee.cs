using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSConsole
{

    // Model
    public class Employee : Person
    {
        public int EmpId { get; set; }

        public Employee(int empid, string name, int age)//:base(age, name)
        {
            this.Name = name;
            this.Age = age;
            this.EmpId = empid;   
        }
    }
}
