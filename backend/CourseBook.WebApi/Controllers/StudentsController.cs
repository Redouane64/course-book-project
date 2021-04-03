namespace CourseBook.WebApi.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Disciplines.Queries;
    using CourseBook.WebApi.Disciplines.ViewModels;

    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}/disciplines", Name = nameof(GetStudentDisciplines))]
        [ProducesResponseType(typeof(StudentDisciplinesViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetStudentDisciplines(
             [FromRoute] string id,
             CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new GetStudentDisciplinesRequest(id), cancellationToken));
        }
    }
}
