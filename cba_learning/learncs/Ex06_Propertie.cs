using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Employee  // poco
    {
        private string _name;
        public Employee()
        {
        }
        #region :: old way of properties ::
        /*private string name;
        int age;

        // contructors or properties 

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }*/
        #endregion

        // internally  a private variable will be created and for that 

        public string Name {
            get { 
                return _name;
            }
            set {
                if (value == null)
                    throw new Exception();
                this._name = value; // value is a keyword
            } 
        }
        public int Age { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Name + ":" + this.Age;
        }

    }

    class Ex06_Propertie
    {
        static void Main()
        {
            Employee e = new Employee();
            //e.SetName("Vijay");
            e.Name = "Vijay";

            Console.WriteLine( e.Name);
        }
    }
}
