using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;
using FirstWebApi.Filters;
using Microsoft.AspNetCore.Http;
namespace FirstWebApi.Controllers
{

[ApiController]

[Route("api/[controller]")]

[CustomAuthFilter] // custom authorization

public class EmployeeController : ControllerBase

{

private static List<Employee> _employees;


static EmployeeController()

{

_employees = GetStandardEmployeeList();

}


[HttpGet]

[ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]

[ProducesResponseType(StatusCodes.Status500InternalServerError)]

public ActionResult<List<Employee>> Get()

{

// Uncomment to test exception filter

// throw new Exception("Test exception from GET");

return Ok(_employees);

}


[HttpGet("standard")]

public ActionResult<Employee> GetStandard()

{

return Ok(_employees.FirstOrDefault());

}


[HttpPost]

public IActionResult Post([FromBody] Employee emp)

{

_employees.Add(emp);

return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);

}


[HttpPut("{id}")]

public IActionResult Put(int id, [FromBody] Employee emp)

{

var existing = _employees.FirstOrDefault(e => e.Id == id);

if (existing == null) return NotFound();

existing.Name = emp.Name;

existing.Salary = emp.Salary;

existing.Permanent = emp.Permanent;

existing.Department = emp.Department;

existing.Skills = emp.Skills;

existing.DateOfBirth = emp.DateOfBirth;

return NoContent();

}


private static List<Employee> GetStandardEmployeeList()

{

return new List<Employee>

{

new Employee

{

Id = 1,

Name = "John",

Salary = 60000,

Permanent = true,

Department = new Department { Id = 1, Name = "HR" },

Skills = new List<Skill>

{

new Skill { Id = 1, Name = "C#" },

new Skill { Id = 2, Name = "SQL" }

},

DateOfBirth = new DateTime(1990, 5, 20)

}

};

}

}

}