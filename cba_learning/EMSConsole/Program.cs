
namespace EMSConsole
{
    class Ex01_Hello
    {
        static void Main()
        {
            EmployeeService employeeService = new EmployeeService();
            Console.WriteLine("Welcome to EMS Application");
            int userOperation = 0;
            do
            {
                
                Console.WriteLine("Select your optins " +
                    "\n 1-Create employee" +
                    "\n 2-Update employee" +
                    "\n 3-Read employee" +
                    "\n 4-Delete employee" +
                    "\n 5-Exit");
                userOperation = Convert.ToInt32(Console.ReadLine());

                switch (userOperation)
                {
                    case 1:
                        // name and age should be capture from user 
                        int empid = Utils.ReadInt("Enter EmployeeId: ");
                        string name = Utils.ReadString("Enter name:");
                        int age = Utils.ReadInt("Enter Age: ");
                        employeeService.CreateEmployee(new Employee(empid, name, age));
                        break;
                    case 5:
                        Console.WriteLine("Thank you");
                        break;  
                }

            }while (userOperation != 5);

        }
    }

    class Utils
    {
        public static int ReadInt(string message)
        {
            Console.Write(message);
            int intval = Convert.ToInt32(Console.ReadLine());
            return intval;
        }
        public static string ReadString(string message)
        {
            Console.Write(message);
            string  stringval = Console.ReadLine();
            return stringval;
        }
    }
}