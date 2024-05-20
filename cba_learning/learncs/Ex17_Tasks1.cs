using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class Ex17_Tasks1
    {
        // task -> threadpool -> processor pick the task from threadpool
          void Main()
        {
            //Task.Factory.StartNew(somefunction);
             somefunctionAsync();
            Console.WriteLine("bye");
           // Console.Read();
        }

        static  void somefunction()
        {
            Console.WriteLine("new thread");
            Task.Delay(1000);
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
        static async Task somefunctionAsync()
        {
            Console.WriteLine("new thread");
            await Task.Delay(1000);
            for (int i = 0; i< 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
