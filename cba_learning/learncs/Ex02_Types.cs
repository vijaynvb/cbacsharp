
namespace learncs
{
    class Ex02_Types
    {
        void Main()
        {
            Console.WriteLine("Types");
            int age = 30;
            double height = 143453453435435433453543543.75;
            bool isMarried = true;
            char gender = 'M';
            string name = "John";

            int j = (int) height;
            //int x= Convert.ToInt32(height);

            //Console.WriteLine(int.MaxValue + ":" + int.MinValue);

            string s1 = "vijay, jai, ram, sham";
            string s2 = s1;

            Console.WriteLine(s1 + ":" + s2);

            s2 = "jai";
            // new memory block will be create
            Console.WriteLine(s1 + ":" + s2);

            s1 = s1.ToLower();
            s1.ToUpper();
            string[] arr = s1.Split(',');

            Console.WriteLine(arr[0]);
            //string consoleval =  Console.ReadLine();

            //Console.WriteLine(consoleval);
            string foldername = "table";

            Console.WriteLine("c:\\newfolder\\table");
            Console.WriteLine( @"c:\newfolder\table");
            string str =  $@"c:\newfolder\{foldername}";
            Console.WriteLine(str);


        }
    }
}
