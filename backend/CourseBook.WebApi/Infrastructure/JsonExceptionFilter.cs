namespace CourseBook.WebApi.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Hosting;

    public class JsonExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;

        public JsonExceptionFilter(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var error = new ApiError();

            if (_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Details = context.Exception.StackTrace;
            }
            else
            {
                error.Message = "Something went wrong in the server.";
                error.Details = context.Exception.Message;
            }

            context.Result = new ObjectResult(error) { StatusCode = 500 };
        }
    }
}
