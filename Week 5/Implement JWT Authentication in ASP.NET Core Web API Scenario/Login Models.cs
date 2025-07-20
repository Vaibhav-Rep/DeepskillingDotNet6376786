using System.ComponentModel.DataAnnotations;
namespace JwtAuthDemo.Models
{

public class LoginModel

{

[Required]

public string Username { get; set; }


[Required]

public string Password { get; set; }

}

}


Appsettings.json:


{

"Jwt": {

"Key": " 12345678901234567890123456789012",

"Issuer": "JwtAuthDemo",

"Audience": "JwtAuthDemoUser"

},

"Logging": {

"LogLevel": {

"Default": "Information",

"Microsoft.AspNetCore": "Warning"

}

},

"AllowedHosts": "*"

}