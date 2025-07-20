using JwtAuthDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace JwtAuthDemo.Controllers

{

[ApiController]

[Route("api/[controller]")]

public class AuthController : ControllerBase

{

private readonly IConfiguration _config;


public AuthController(IConfiguration config)

{

_config = config;

}


[HttpPost("login")]

public IActionResult Login([FromBody] LoginModel model)

{

if (IsValidUser(model))

{

var token = GenerateJwtToken(model.Username);

return Ok(new { Token = token });

}


return Unauthorized();

}


private bool IsValidUser(LoginModel model)

{

// For demo purposes; replace with real user check

return model.Username == "ravi" && model.Password == "ravi123";

}


private string GenerateJwtToken(string username)

{

var claims = new[]

{

new Claim(ClaimTypes.Name, username)

};


// Use GetValue with null-check to avoid CS8604

var keyString = _config.GetValue<string>("Jwt:Key")

?? throw new InvalidOperationException("JWT Key is missing in configuration.");


var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));

var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


var token = new JwtSecurityToken(

issuer: _config["Jwt:Issuer"],

audience: _config["Jwt:Audience"],

claims: claims,

expires: DateTime.Now.AddMinutes(

Convert.ToDouble(_config["Jwt:DurationInMinutes"] ?? "60")),

signingCredentials: creds

);


return new JwtSecurityTokenHandler().WriteToken(token);

}

}

}