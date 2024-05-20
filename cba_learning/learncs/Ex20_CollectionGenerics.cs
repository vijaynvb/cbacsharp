using System;
using System.Collections.Generic;


namespace learncs
{
    class Ex20_CollectionGenerics
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("vijay");
            list.Add("a");
            list.Add("b");
            list.Add("a");


           /* list.Sort();
            list.Remove("vijay");
            list.RemoveAt(0);

            list.Clear();*/

            list.ForEach(x => Console.WriteLine(x));

            list.Contains("a");

            list.Find(x => x == "a");

            List<string> allA = list.FindAll(x => x == "a");

        }
    }
}
