using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncs
{
    class log { 
        public virtual void display()
        {
            Console.WriteLine("display console");
        }
    }
    class filelog : log
    {
        public override void display()
        {
            Console.WriteLine("display file");
        }
    }
    class remotelog : filelog
    {
        public override void display()
        {
            Console.WriteLine("log to remote server");
        }

    }

    class Ex08_Inheritance
    {
         void Main()
        {
            log a = new log();
           // a.display(); // A console

            a = new filelog();
            //a.display(); //console
            a.display(); // B file

            //a.display();
            a = new remotelog();
          //  a.display(); // B file
        }
    }

    class hpv1
    {
        public virtual void print()
        {
        }
    }

    class hpv2 : hpv1
    {
        public override void print()
        {
        }
        public virtual void fax()
        {
        }
    }
    class hpv3 : hpv2
    {
        public override void print()
        {
        }
        public override void fax()
        {
        }
        public virtual void scan()
        {
        }
    }
}
