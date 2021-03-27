namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.ViewModels;
    using CourseBook.WebApi.Disciplines.Queries;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Queries;

    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class DisciplinesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DisciplinesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = nameof(GetDisciplines))]
        [ProducesResponseType(typeof(ItemsCollection<DisciplineViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDisciplines(CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new GetDisciplinesRequest(), cancellationToken));
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(DisciplineDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDiscipline([FromRoute] Guid id)
        {
            var discipline = await this._mediator.Send(new GetDisciplineRequest(id));

            if (discipline is null)
            {
                return NotFound();
            }

            return Ok(discipline);
        }

        [HttpGet("{teacherId}")]
        [ProducesResponseType(typeof(DisciplineDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTeacherDisciplines([FromRoute] string teacherId)
        {
            var teacherDisciplines = await this._mediator.Send(new GetTeacherDisciplinesRequest(teacherId));

            if (teacherDisciplines is null)
            {
                return NotFound();
            }

            return Ok(teacherDisciplines);
        }


        [HttpGet("{studentId}")]
        [ProducesResponseType(typeof(DisciplineDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentDisciplines([FromRoute] string studentId)
        {
            var studentDisciplines = await this._mediator.Send(new GetStudentDisciplinesRequest(studentId));

            if (studentDisciplines is null)
            {
                return NotFound();
            }

            return Ok(studentDisciplines);
        }
    }
}

