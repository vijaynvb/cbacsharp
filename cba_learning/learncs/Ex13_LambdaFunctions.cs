using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Ex13_LambdaFunctions
    {
        delegate void Notifier(string message);
        delegate int Calcuator(int a, int b);
        delegate int Counter(int a);
          void Main()
        {
            Notifier greetings;
            Calcuator calc;
            Counter counter;

            greetings = new Notifier((string name) => { Console.WriteLine("Welcome " + name);});
            /*greetings += new Notifier((name) => { Console.WriteLine("Welcome " + name); });
            greetings += new Notifier((name) => Console.WriteLine("Welcome " + name));
            greetings += new Notifier(name => Console.WriteLine("Welcome " + name));*/
            greetings += name => Console.WriteLine("Welcome " + name);

            calc = new Calcuator((int a, int b) => { return a + b; });
            calc += new Calcuator((a, b) => { return a + b; });
            calc += new Calcuator((a, b) =>  a + b );

            counter = new Counter((int a) => { return a++; });
            counter += a => ++a;

            // () => {}
            greetings("vijay");
            int str = counter(2);


            Func<int> test = () => { int a = 10; a++; return a; };
        }

        public static int calc(int a, int b)
        {
            return a + b;
        }
        public static int calc(int a)
        {
            return ++a;
        }
    }
}
