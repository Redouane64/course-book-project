using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseBook.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FacultiesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetFaculty() => Ok();

        [HttpPost]
        public async Task<IActionResult> CreateFaculty() => Ok();

        [HttpPut]
        public async Task<IActionResult> UpdateFaculty() => Ok();

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok();

        [HttpDelete]
        public async Task<IActionResult> DeleteFaculty() => Ok();

    }
}
