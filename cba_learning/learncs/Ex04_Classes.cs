using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Person
    {
        int age = 10;
        string name;
        public Person()
        {
        }
        public Person(int age, string name)
        {
        }
        #region :: My Display Method ::
        ~Person() // frees the object -> notifiys the GC to free it 
        {
            // any other resources you can invoke other destructors
            // file
        }

        public void display()
        {
            Console.WriteLine("something" + age);
        }
       
        #endregion
    }
    class Ex04_Classes
    {
         void Main()
        {
            Person p =  new Person();
            p.display();
        }
    }
}
