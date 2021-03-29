namespace CourseBook.WebApi.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.ViewModels;
    using CourseBook.WebApi.Disciplines.ViewModels;
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

        [HttpGet("{id}/disciplines",Name = nameof(GetTeacherDisciplines))]
        [ProducesResponseType(typeof(ItemsCollection<TeacherDisciplineViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTeacherDisciplines(
             [FromRoute] string id,
             CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new GetTeacherDisciplinesRequest(id), cancellationToken));
        }

    }
}
