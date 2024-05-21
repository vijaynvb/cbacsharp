using EMSApi.Model;

namespace EMSApi.Repository
{
    public interface IEmployeeRepo
    {
        public List<Employee> getAll();
        public Employee getById(int id);

        public Employee createEmployee(Employee newEmp);
        public Employee updateEmployee(int id, Employee newEmp);

        public Employee deleteEmployee(int id);

    }
}
