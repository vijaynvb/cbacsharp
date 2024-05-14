using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    internal class Ex03_Methods
    {
        public void Greetings(string name)
        {
            Console.WriteLine("Welcome "+ name);
        }
        /*public static void GreetingsStatic(string name)
        {
            Console.WriteLine("Welcome " + name);
        }*/

        public static void GreetingsStatic(string name, int age=18)
        {
            Console.WriteLine("Welcome {0} your age is {1} {2}  {3} ", name, age, name, age);
        }

        public static void GreetingsStatic(bool? isAlive)
        {
            // set for default value for null variable
           // isAlive = isAlive ?? false;
            if(isAlive != null)
                if (isAlive.Value) // null ture or false
                    Console.WriteLine("Your alive");
                else
                    Console.WriteLine("your dead");
        }

        public static void add( ref int? a,in int b)
        {
            a =  a + b;
        }

        public static void cal(in int a, in int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }

        public static int sumofnnumbers(int a , int b, params int[] nno)
        {
            int sum = 0;
            if (nno != null)
                foreach (int i in nno)
                    sum += i;
            return a + b + sum;
        }

        public static string WriteLine(string format, params string[] arr)
        {
            //format = "sum of two number:{0}";
            //arr[0] = "12";
            return "fomrated string";
        }

         void Main()
        { 
            Ex03_Methods m = new Ex03_Methods();
            m.Greetings("vijay");

            Ex03_Methods.GreetingsStatic("Vijay");
            Ex03_Methods.GreetingsStatic("Vijay", 12);
            Ex03_Methods.GreetingsStatic(age: 12, name: "Vijay");

            Ex03_Methods.GreetingsStatic(null);

            int? a = null;

            // in out ref params
            int? a1 = 2;
            //add(ref a1, 3);

            int sum, sub, mul = 0;
            cal(2, 3, out sum, out sub, out mul);

            Console.WriteLine("sum of two number:{0} \n" +
                "sub of two number:{1} \n" +
                "mul of two number:{2} \n", sum,sub,mul);

            Console.WriteLine("sum of n number:"+ sumofnnumbers(1, 2));
            Console.WriteLine("sum of n number:"+ sumofnnumbers(1, 2,3));
            Console.WriteLine("sum of n number:"+ sumofnnumbers(1, 2,3,4));
            Console.WriteLine("sum of n number:"+ sumofnnumbers(1, 2, 3, 4, 5));

            WriteLine("sum of two number:{0}{1}{2}", "12","13","14");
        }


    }
}
