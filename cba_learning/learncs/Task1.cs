using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    internal class Task1
    {
        static void Main()
        {
            string str = "in my sentance ";
            string[] arr = str.Split(' ');
            int count = 0;
            foreach(string s in arr)
            {
                if(s.Length % 2 == 0)
                    count++;
            }
            //Console.WriteLine(count);

            string str1 = "in my sentance ";

            str1.Split(' ').ToList<string>().ForEach(x =>
            {
                if (x.Length % 2 == 0)
                    Console.WriteLine(x);
            });
        }
    }
}
