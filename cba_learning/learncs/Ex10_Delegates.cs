using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Ex10_Delegates
    {
        // step 1: declare
        delegate void Notifier(string message);
        delegate string Notifier1(string message, string daytime);
        void Main()
        {
            // step 2: declare variable 
            Notifier greetings;
            Notifier1 greetings1;

            // step 3: assign a function
            greetings = new Notifier(SayHello);

            // step 4: call delegate
            greetings("vijay");

            greetings1 = new Notifier1(SayBye);

            string msg = greetings1("vijay", "good eveing");
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Welcome "+ name);
        }

        public static string SayBye(string name, string daytime)
        {
            Console.WriteLine("Bye " + name +":"+daytime);
            return "bye";
        }
    }
}
