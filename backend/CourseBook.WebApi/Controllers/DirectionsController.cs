namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DirectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetDirection([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet("{id:Guid}/groups", Name = nameof(GetDirectionGroups))]
        public async Task<IActionResult> GetDirectionGroups([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var groups = await this._mediator.Send(new GetGroupsRequest(id), cancellationToken);
            return Ok(groups);
        }

    }
}

