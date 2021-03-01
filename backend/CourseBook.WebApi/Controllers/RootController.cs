namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new {  Message = "Ok" });
    }
}
