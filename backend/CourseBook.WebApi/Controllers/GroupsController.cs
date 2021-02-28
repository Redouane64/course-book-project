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
    public class GroupsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetGroup() => Ok();

        [HttpPost]
        public async Task<IActionResult> CreateGroup() => Ok();

        [HttpPut]
        public async Task<IActionResult> UpdateGroup() => Ok();

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok();

        [HttpDelete]
        public async Task<IActionResult> DeleteGroup() => Ok();
    }
}
