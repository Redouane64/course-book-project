namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Faculties.Queries;
    using CourseBook.WebApi.Faculties.ViewModels;
    using CourseBook.WebApi.Model;
    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class FacultiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FacultiesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = nameof(GetFaculties))]
        [ProducesResponseType(typeof(IEnumerable<FacultyViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFaculties(CancellationToken cancellationToken = default)
        {
            var faculties = await this._mediator.Send(new GetFacultiesRequest(), cancellationToken);
            return Ok(faculties);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(FacultyDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetFaculty([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var faculty = await this._mediator.Send(new DeleteFacultyRequest(id), cancellationToken);

            if (faculty is null)
            {
                return NotFound();
            }

            return Ok(faculty);
        }


        [HttpPost(Name = nameof(CreateFaculty))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateFaculty([FromBody]CreateFaculty payload, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteFaculty))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteFaculty([FromRoute]Guid facultyId, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
