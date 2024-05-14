using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    internal class Task1
    {
         void Main()
        {
           // string str = "in my sentance ";
           // string[] arr = str.Split(' ');
            int count = 0;
            foreach(string s in "in my sentance ".Split(' '))
            {
                if(s.Length % 2 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
