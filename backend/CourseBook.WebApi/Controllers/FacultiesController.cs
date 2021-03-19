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
    public class FacultiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FacultiesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = nameof(GetFaculties))]
        public async Task<IActionResult> GetFaculties(CancellationToken cancellationToken = default)
        {
            var faculties = await this._mediator.Send(new GetFacultiesRequest(), cancellationToken);
            return Ok(faculties);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetFaculty([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet("{facultyId:Guid}/directions", Name = nameof(GetFacultyDirection))]
        public async Task<IActionResult> GetFacultyDirection([FromRoute]Guid facultyId, CancellationToken cancellationToken = default)
        {
            var directions = await this._mediator.Send(new GetDirectionsRequest(facultyId), cancellationToken);
            return Ok(directions);
        }

    }
}
