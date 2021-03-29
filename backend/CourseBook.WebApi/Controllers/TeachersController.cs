namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Common.ViewModels;
    using CourseBook.WebApi.Disciplines.Queries;
    using CourseBook.WebApi.Faculties.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class TeachersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeachersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetDisciplines))]
        [ProducesResponseType(typeof(ItemsCollection<>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDisciplines(
             [FromQuery(Name = "teacher")] string teacherId,
             CancellationToken cancellationToken = default)
        {
            if (teacherId is not null)
            {
                return Ok(await this._mediator.Send(new GetTeacherDisciplinesRequest(teacherId), cancellationToken));
            }

            // fallback: return all disciplines.
            return Ok(await this._mediator.Send(new GetDisciplinesRequest(), cancellationToken));
        }

    }
}
