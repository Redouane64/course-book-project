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
    public class DisciplinesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DisciplinesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = nameof(GetDisciplines))]
        public async Task<IActionResult> GetDisciplines(CancellationToken cancellationToken = default)
        {
            var disciplines = await this._mediator.Send(new GetDisciplinesRequest(), cancellationToken);
            return Ok(disciplines);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetDiscipline([FromRoute] Guid id)
        {
            return Ok();
        }
    }
}

