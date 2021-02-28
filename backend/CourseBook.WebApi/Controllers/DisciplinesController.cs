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
    public class DisciplinesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDiscipline() => Ok();

        [HttpPost]
        public async Task<IActionResult> CreateDiscipline() => Ok();

        [HttpPut]
        public async Task<IActionResult> UpdateDiscipline() => Ok();

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok();

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscipline() => Ok();
    }
}
