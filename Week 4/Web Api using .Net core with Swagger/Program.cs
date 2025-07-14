using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Hosting;

using Microsoft.OpenApi.Models;

using System;


namespace SwaggerDemo

{

public class Startup

{

public Startup(IConfiguration configuration)

{

Configuration = configuration;

}


public IConfiguration Configuration { get; }


// 1. Paste this method inside the Startup class

public void ConfigureServices(IServiceCollection services)

{

services.AddControllers();


// Add Swagger configuration here

services.AddSwaggerGen(c =>

{

c.SwaggerDoc("v1", new OpenApiInfo

{

Title = "Swagger Demo",

Version = "v1",

Description = "TBD",

TermsOfService = new Uri("https://example.com/terms"),

Contact = new OpenApiContact

{

Name = "John Doe",

Email = "john@xyzmail.com",

Url = new Uri("https://www.example.com")

},

License = new OpenApiLicense

{

Name = "License Terms",

Url = new Uri("https://www.example.com")

}

});

});

}


// 2. Paste this method inside the same Startup class

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

{

if (env.IsDevelopment())

{

app.UseDeveloperExceptionPage();

}


app.UseRouting();


// Enable Swagger middleware

app.UseSwagger();


app.UseSwaggerUI(c =>

{

c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");

});


app.UseAuthorization();


app.UseEndpoints(endpoints =>

{

endpoints.MapControllers();

});

}

}

}