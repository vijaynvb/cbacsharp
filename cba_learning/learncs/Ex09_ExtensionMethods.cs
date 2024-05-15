using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{

    class Emp
    {

    }
    class Ex09_ExtensionMethods
    {

        static void Main()
        {
            string str = "some content";

            string str2 = "test";

            Emp emp = new Emp();

            emp.MaskData();

            str.ToUpper();
            str.MaskData();
            Console.WriteLine(str);
            
            int a = 0;
            Console.WriteLine(a.MaskData());
        }
    }

    static class ExtensionMethods
    {
        public static string MaskData( this string str)
        {
             str = str.Replace('o', 'x');
            return str;
        }

        public static string MaskData(this int str)
        {
            return "XXXX";
        }

        public static string MaskData(this Emp str)
        {
            return "XXXX";
        }
    }
}
