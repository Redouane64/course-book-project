namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Directions.Queries;
    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Faculties.Queries;
    using CourseBook.WebApi.Model;
    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("{facultyId:Guid}/[controller]")]
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
        [ProducesResponseType(typeof(DirectionDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDirection([FromRoute] Guid id)
        {
            var direction = await this._mediator.Send(new GetDirectionRequest(id));

            if (direction is null)
            {
                return NotFound();
            }

            return Ok(direction);
        }

        [HttpGet(Name = nameof(GetFacultyDirection))]
        [ProducesResponseType(typeof(IEnumerable<DirectionViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFacultyDirection([FromRoute] Guid facultyId, CancellationToken cancellationToken = default)
        {
            var directions = await this._mediator.Send(new GetDirectionsRequest(facultyId), cancellationToken);
            return Ok(directions);
        }


        [HttpPost(Name = nameof(CreateDirection))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateDirection([FromBody] CreateDirection payload, CancellationToken cancellationToken)
        {
            var id = await this._mediator.Send(new CreateDirectionRequest(payload), cancellationToken);
            return CreatedAtAction(nameof(GetDirection), routeValues: new { id, facultyId = payload.FacultyId }, null);
        }

        [HttpDelete("{id:Guid}", Name = nameof(DeleteDirection))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteDirection([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            await this._mediator.Send(new DeleteDirectionRequest(id), cancellationToken);
            return NoContent();
        }
    }
}

