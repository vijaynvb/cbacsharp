using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Ex21_PreBuiltDelgates
    {
        // action -> call a method and do not return anything

      /*  delegate void Action();
        // function -> pass some[1 or more] paramenters and return a value 

        delegate T Func<T>(T a);
        // predicate -- will return a boolean 

        delegate bool Predicate<T>(T a);*/


         void Main()
        {
            Action action = () => Console.WriteLine("test");
            //action += () => Console.WriteLine("somthing");

            action();

            //string outval=null;
            string name = "vijay";
            string age = "12";

            Func<string, string> func = name => name.ToLower();
            Func<string, string, string> func2 = (name, age) => name + age;

            int val = 4;
            Predicate<int> predicate = (val) => { return val < 5; };


            List<int> list = new List<int>();   
            list.Add(1);
            list.Add(19);
            list.Add(3);
            list.Add(42);
            list.Add(54);

            //list.ForEach((x) => Console.WriteLine(x));

            list.ForEach(Console.WriteLine);

            int sum = list.Sum<int>(x => x);

            Console.WriteLine("sum" + sum);
        }
    }
}
