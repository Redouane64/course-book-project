using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {

        [HttpGet(Name = nameof(GetGroup))]
        public async Task<IActionResult> GetGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost(Name = nameof(CreateGroup))]
        public async Task<IActionResult> CreateGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateGroup))]
        public async Task<IActionResult> UpdateGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAll))]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteGroup))]
        public async Task<IActionResult> DeleteGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }

}
