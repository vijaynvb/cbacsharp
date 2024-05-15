using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    // anonymous functions in delegates
    class Ex11_Delegate1
    {
        delegate void Notifier(string message);

        delegate int Notifier1(string message);
         void Main()
        {
            Notifier greetings;
            Notifier1 greetings1;

            greetings = new Notifier(SayHello);

            greetings1 = delegate (string message)
            {
                Console.WriteLine(message);
                return 1;
            };
            greetings1("vijay");
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

}
}
