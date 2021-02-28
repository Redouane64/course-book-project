using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDirection() => Ok();

        [HttpPost]
        public async Task<IActionResult> CreateDirection() => Ok();

        [HttpPut]
        public async Task<IActionResult> UpdateDirection() => Ok();

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok();

        [HttpDelete]
        public async Task<IActionResult> DeleteDirection() => Ok();
    }
}
