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
    public class DirectionsController : ControllerBase
    {

        [HttpGet(Name = nameof(GetDirection))]
        public async Task<IActionResult> GetDirection(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost(Name = nameof(CreateDirection))]
        public async Task<IActionResult> CreateDirection(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateDirection))]
        public async Task<IActionResult> UpdateDirection(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAll))]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteDirection))]
        public async Task<IActionResult> DeleteDirection(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}

