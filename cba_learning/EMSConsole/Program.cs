
namespace EMSConsole
{

    // Runner Class 
    class Ex01_Hello
    {
        static void Main()
        {
            // tightly coupled code 
            // losely coupled

            string option = Utils.ReadString("Give the Fully Qualified Class Name to Employee Service \n");
            IEmployeeSvc employeeService;

            employeeService = (IEmployeeSvc) Utils.GetInstance(option);
            // reflection by taking only the name of a class string EmployeeService
            /*if (option == 1)
                 employeeService = new EmployeeService();
            else if (option == 2)
                employeeService = new EmployeeServiceDB();
            else
                employeeService = new EmployeeService();*/


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
                    case 2:
                        int empid1 = Utils.ReadInt("Enter EmployeeId: ");
                        int age1 = Utils.ReadInt("Enter Age: ");
                        employeeService.UpdateEmployee(empid1, age1);
                        break;
                    case 3:
                        int empid2 = Utils.ReadInt("Enter EmployeeId: ");
                        employeeService.ReadEmployee(empid2);
                        break;
                    case 4:
                        int empid3 = Utils.ReadInt("Enter EmployeeId: ");
                        employeeService.DeleteEmployee(empid3);
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

        public static object GetInstance(string fullyQualifiedName) // EMSConsole.EmployeeService
        {
            // reflectio logic to create a object

            Type type = Type.GetType(fullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            
            return null;
        } 
    }
}