using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;


namespace JwtAuthDemo.Controllers

{

[ApiController]

[Route("api/[controller]")]

public class SecureController : ControllerBase

{

[HttpGet]

[Authorize]

public IActionResult Get()

{

return Ok(" This is a protected endpoint!");

}

}

}