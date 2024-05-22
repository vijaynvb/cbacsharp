using EMSApi.DTO;
using EMSApi.Model;
using EMSApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        IEmployeeRepo _empRep; // = new EmployeeRepoitoryInMem();

        public EmployeesController(IEmployeeRepo empRepo) // .net core will inject the object from container
        {
            _empRep = empRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> empList = _empRep.getAll();
            if(empList == null)
                return NotFound();
            else
                return Ok(empList);
        }

        [HttpGet]
        [Route("{id}")] // ----/employees/id
        public IActionResult GetByID(int id) // model binding 
        {
            Employee emp = _empRep.getById(id);
            if (emp == null)
                return NotFound();
            else
                return Ok(emp);
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDTO emp) // model binding + validation framework
        {
            Employee interiemEmployee = new Employee();
            interiemEmployee.Name = emp.Name;
            interiemEmployee.Age = emp.Age;
            Employee newEmp = _empRep.createEmployee(interiemEmployee);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Created("",newEmp);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(int id, Employee emp) // model binding 
        {
            Employee newEmp = _empRep.updateEmployee(id, emp);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Ok(newEmp);
        }

        [HttpDelete]
        [Route("{id}")] // ----/employees/id
        public IActionResult DeleteEmployee(int id) // model binding 
        {
            Employee newEmp = _empRep.deleteEmployee(id);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Ok(newEmp);
        }

    }
}