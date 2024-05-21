using EMSApi.Model;
using EMSApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        EmployeeRepoitoryInMem _empRep = new EmployeeRepoitoryInMem();

        [HttpGet]
        public List<Employee> GetAll()
        {
            return _empRep.getAll();
        }

        [HttpGet]
        [Route("{id}")] // ----/employees/id
        public Employee GetByID(int id) // model binding 
        {
            return _empRep.getById(id);
        }

        [HttpPost]
        public Employee CreateEmployee(Employee emp) // model binding 
        {
            return _empRep.createEmployee(emp);
        }

        [HttpPut]
        [Route("{id}")]
        public Employee UpdateEmployee(int id, Employee emp) // model binding 
        {
            return _empRep.updateEmployee(id, emp);
        }

        [HttpDelete]
        [Route("{id}")] // ----/employees/id
        public Employee DeleteEmployee(int id) // model binding 
        {
            return _empRep.deleteEmployee(id);
        }

    }
}