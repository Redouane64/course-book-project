namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Queries;
    using CourseBook.WebApi.ViewModels;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class DirectionsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DirectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(DirectionViewModel), StatusCodes.Status200OK)]
        public IActionResult GetDirection([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet("{id:Guid}/groups", Name = nameof(GetDirectionGroups))]
        [ProducesResponseType(typeof(IEnumerable<DirectionViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDirectionGroups([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var groups = await this._mediator.Send(new GetGroupsRequest(id), cancellationToken);
            return Ok(groups);
        }

    }
}

