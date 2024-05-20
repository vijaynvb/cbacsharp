using System;
using System.Collections;
using System.Linq;

namespace learncs
{
    class Ex19_ArrayList
    {
         void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(5);
            arrayList.Add("vijay");
            Console.WriteLine("size of array: " + arrayList.Count);
            
            //arrayList.Clear();  // clean your array.

             bool result= arrayList.Contains(1);

            //arrayList.Remove(1); // value 
            //arrayList.RemoveAt(0); // posiion

            arrayList[0].ToString();

            arrayList.Sort();

            foreach(var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("size of array: " + arrayList.Count);


        }
    }
}
