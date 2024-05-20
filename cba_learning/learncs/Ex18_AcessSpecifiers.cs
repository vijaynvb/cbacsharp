using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class MyClass1
    {
        // private
        internal int x = 10;
    }

    // is a
    class MyClass2 : MyClass1
    {

    }
    class Ex18_AcessSpecifiers
    {
         void Main()
        {
            MyClass1 my = new MyClass1();

            // has relations
            my.x = 10;
        }
        
    }
}
