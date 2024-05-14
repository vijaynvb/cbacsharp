using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{

    class Address
    {
        string street;
        public Address(string str)
        {
            this.street = str;
        }
    }
    class Person1
    {
        static List<Address> list = new List<Address>();
        static Person1()
        {
            // file or api 
            list.Add(new Address("mystree"));
        }

        public Person1()
        {

        }

    }

     class Ex05_StaticCtor
    {
         void Main()
        {

            Person1 p = new Person1(); //object controctor

        }
    }
}
