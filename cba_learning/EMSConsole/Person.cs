using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSConsole
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {

        }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
