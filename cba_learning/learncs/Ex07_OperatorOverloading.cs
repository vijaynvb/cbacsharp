using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{

    class Fraction
    {
        int n, d;
        public Fraction(int n, int d)
        {
            this.n = n;
            this.d = d; 
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction(f1.n + f2.n, f1.d + f2.d);
        }

        public override string ToString()
        {
            return $"{n} \\ {d}";
        }
    }
    class Ex07_OperatorOverloading
    {
         void Main()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);

            Fraction f3 = f1 + f2;
            //Console.WriteLine("sum of two fractions: " + f3);

            string str = "vijay";
            string str1 = null; // undefined

            String str2 = "Vijay";

            Console.WriteLine(str == str1);

        }
    }
}
