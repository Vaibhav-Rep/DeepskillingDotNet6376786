using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;
using System.Collections.Generic;
using System.Linq;
namespace FirstWebApi.Controllers

{

[ApiController]

[Route("api/[controller]")]

public class EmployeesController : ControllerBase

{

// Hardcoded list of employees (static to persist in memory)

private static List<Employee> employees = new List<Employee>

{

new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },

new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000 },

new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 55000 }

};


// CREATE: POST /api/employees

[HttpPost]

public ActionResult<Employee> CreateEmployee([FromBody] Employee newEmployee)

{

newEmployee.Id = employees.Max(e => e.Id) + 1;

employees.Add(newEmployee);

return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, newEmployee);

}

// READ: GET /api/employees/{id}

[HttpGet("{id}")]

public ActionResult<Employee> GetEmployee(int id)

{

var emp = employees.FirstOrDefault(e => e.Id == id);

if (emp == null)

return NotFound("Employee not found");

return Ok(emp);

}

// UPDATE: PUT /api/employees/{id}

[HttpPut("{id}")]

public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)

{

if (id <= 0)

return BadRequest("Invalid employee id");

var existing = employees.FirstOrDefault(e => e.Id == id);

if (existing == null)

return BadRequest("Invalid employee id");

existing.Name = updatedEmployee.Name;

existing.Department = updatedEmployee.Department;

existing.Salary = updatedEmployee.Salary;

return Ok(existing);

}

// DELETE: DELETE /api/employees/{id}

[HttpDelete("{id}")]

public ActionResult DeleteEmployee(int id)

{

var emp = employees.FirstOrDefault(e => e.Id == id);

if (emp == null)

return NotFound("Employee not found");

employees.Remove(emp);

return Ok("Employee deleted successfully");

}

}

}
