using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;
namespace FirstWebApi.Filters

{

public class CustomExceptionFilter : IExceptionFilter

{

public void OnException(ExceptionContext context)

{

var exception = context.Exception;

File.AppendAllText("logs.txt", $"{DateTime.Now} - {exception.Message}\n");


context.Result = new ObjectResult("Internal Server Error")

{

StatusCode = 500

};

}

}

}