namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DirectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{facultyId}", Name = nameof(GetDirection))]
        public async Task<IActionResult> GetDirection([FromRoute]string facultyId, CancellationToken cancellationToken = default)
        {
            var directions = await this._mediator.Send(new GetDirectionsRequest(facultyId), cancellationToken);
            return Ok(directions);
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

        [HttpGet(Name = nameof(GetAllDirections))]
        public async Task<IActionResult> GetAllDirections(CancellationToken cancellationToken = default)
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

