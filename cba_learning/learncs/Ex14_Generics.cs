using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class MyClass
    {
        public string Name { get; set; }

        public static MyClass operator +(MyClass f1, MyClass f2)
        {
            MyClass merge = new MyClass();
            merge.Name = f1.Name;
            merge.Name += f2.Name;
            return merge;
        }
    }

    class Addition<T>
    {
        T a;
        T b;
        public Addition(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public T Add()
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }

    class Ex14_Generics
    {
        int a=0;
        int b=0;

        static void Main()
        {
            int c = add<int>(2, 4);

            double d = add<double>(5.75, 6.6);

            string s = add<string>("welcome", "generics");

            var obj1 = new MyClass();
            obj1.Name = "vijay";
            var obj2 = new MyClass();
            obj2.Name = "reddy";

            MyClass mc = add<MyClass>(obj1, obj2);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.WriteLine(mc.Name);

            //Addition addition = new Addition(1,2);
            Addition<int> addition = new Addition<int>(1, 2);
        }

        public static T add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }
}
