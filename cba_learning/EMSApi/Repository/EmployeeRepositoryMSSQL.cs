using EMSApi.Data;
using EMSApi.Model;

namespace EMSApi.Repository
{
    public class EmployeeRepositoryMSSQL : IEmployeeRepo
    {

        EMSDbContext _dbContext = new EMSDbContext();
        public Employee createEmployee(Employee emp)
        {
           Employee newEmp = _dbContext.Employees.Add(emp).Entity; // 0, 
           _dbContext.SaveChanges(); // commit 
           return emp;
        }

        public Employee deleteEmployee(int id)
        {
            Employee emp = getById(id);
            if (emp != null)
            {
                _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges() ;
            }
            return emp;
        }

        public List<Employee> getAll()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee getById(int id)
        {
           return _dbContext.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee updateEmployee(int id, Employee newEmp) // new values
        {
            var emp = _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);
            if (emp != null)
            {
                // emp.ID = newEmp.ID;
                emp.Name = newEmp.Name;
                emp.Age = newEmp.Age;
                _dbContext.Employees.Update(emp);
                _dbContext.SaveChanges();
                return emp;
            }
            else
                return null;
        }
    }
}
