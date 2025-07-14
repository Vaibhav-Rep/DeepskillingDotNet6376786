using FirstWebApi.Filters;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);


// Register services + exception filter

builder.Services.AddControllers(options =>

{

options.Filters.Add<CustomExceptionFilter>();

});


// Add Swagger + Bearer Auth support

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>

{

c.SwaggerDoc("v1", new OpenApiInfo

{

Title = "Swagger Demo",

Version = "v1",

Description = "Custom Model, Authorization, Exception Filter"

});


// 🔐 Add support for Authorization header

c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme

{

Description = "Enter 'Bearer' followed by your token.\nExample: Bearer abc123",

Name = "Authorization",

In = ParameterLocation.Header,

Type = SecuritySchemeType.ApiKey,

Scheme = "Bearer"

});


c.AddSecurityRequirement(new OpenApiSecurityRequirement

{

{

new OpenApiSecurityScheme

{

Reference = new OpenApiReference

{

Type = ReferenceType.SecurityScheme,

Id = "Bearer"

}

},

new string[] {}

}

});

});


var app = builder.Build();


// Use Swagger

if (app.Environment.IsDevelopment())

{

app.UseSwagger();

app.UseSwaggerUI();

}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();