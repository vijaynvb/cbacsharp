using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    // multicast delegate
    class Ex12_Delegate2
    {
        delegate void Notifier(string message);
        static void  Main()
        {
            Notifier greetings;
            greetings = new Notifier(SayHello);
            greetings += new Notifier(SayBye);
            greetings -= new Notifier(SayHello);
            greetings("vijay");
        }
        public static void SayHello(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public static void SayBye(string name)
        {
            Console.WriteLine("Bye " + name);
        }
    }
}
