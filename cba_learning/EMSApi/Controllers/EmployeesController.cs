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
        public IActionResult CreateEmployee(Employee emp) // model binding 
        {
            Employee newEmp = _empRep.createEmployee(emp);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Created("",_empRep.createEmployee(emp));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateEmployee(int id, Employee emp) // model binding 
        {
            Employee newEmp = _empRep.updateEmployee(id, emp);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Ok(_empRep.createEmployee(emp));
        }

        [HttpDelete]
        [Route("{id}")] // ----/employees/id
        public IActionResult DeleteEmployee(int id) // model binding 
        {
            Employee newEmp = _empRep.deleteEmployee(id);
            if (newEmp == null)
                return BadRequest("Data not valid");
            else
                return Ok(_empRep.createEmployee(newEmp));
        }

    }
}