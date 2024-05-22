using EMSApi.Model;

namespace EMSApi.Repository
{
    public class EmployeeRepositoryInMem : IEmployeeRepo
    {
        List<Employee> empList = new List<Employee>();

        public EmployeeRepositoryInMem()
        {
            empList.Add(new Employee(1,"vijay", 12));
            empList.Add(new Employee(2, "jai", 13));
            empList.Add(new Employee(3, "bob", 14));
            empList.Add(new Employee(4, "john", 15));
        }

        public List<Employee> getAll()
        {
            return empList;
        }
        public Employee getById(int id)
        {
            return empList.Find(e => e.Id == id);
        }

        public Employee createEmployee(Employee newEmp)
        {
            newEmp.Id = empList.Max(e => e.Id) + 1;
            empList.Add(newEmp);
            return newEmp;
        }
        public Employee updateEmployee(int id, Employee newEmp)
        {
            deleteEmployee(id);
            empList.Add(newEmp);
            return newEmp;
        }

        public Employee deleteEmployee(int id)
        {
            Employee oldEmp = empList.Find(e => e.Id == id);
            if (oldEmp != null)
            {
                empList.Remove(oldEmp);
            }
            return oldEmp;
        }

    }
}
