using System;
using System.Threading;

namespace learncs
{
    class Ex15_Threads
    {
         void Main()
        {
            Console.WriteLine("Main Thread");
           // Thread.Sleep(TimeSpan.FromSeconds(10));

            // new thread
            Thread thread1 = new Thread(printnumber);
            thread1.Name = "Thread 2";
            thread1.Start();

            // new thread
            Thread thread2 = new Thread(printnumber);
            thread2.Name = "Thread 3";
            thread2.Start();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        public static void printnumber()
        {
            Console.WriteLine("new thread");
            Thread.Sleep(1000);
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
