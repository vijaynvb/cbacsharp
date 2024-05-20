using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace learncs
{
    class Ex16_ThreadStatesNFlow
    {
         void Main()
        {
            Console.WriteLine("Main Thread");
           
            // new thread
            Thread thread1 = new Thread(printnumber);
            thread1.Name = "Thread 2";
            thread1.Start();
            Console.WriteLine(thread1.ThreadState.ToString());
           /* thread1.Suspend();
            thread1.Abort();*/
           // wait for new thread to complete 
            
            thread1.Join();
            Console.WriteLine("main thread:"+Thread.CurrentThread.ManagedThreadId);
        }

        public static void printnumber()
        {
            Console.WriteLine("new thread");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ":" + i);
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

    }
    }
