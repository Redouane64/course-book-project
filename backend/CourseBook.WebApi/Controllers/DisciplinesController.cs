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
    public class DisciplinesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DisciplinesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = nameof(GetDisciplines))]
        [ProducesResponseType(typeof(IEnumerable<DisciplineViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDisciplines(CancellationToken cancellationToken = default)
        {
            var disciplines = await this._mediator.Send(new GetDisciplinesRequest(), cancellationToken);

            return Ok(disciplines);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(DisciplineDetailsViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDiscipline([FromRoute] Guid id)
        {
            var discipline = await this._mediator.Send(new GetDisciplineRequest(id));

            if(discipline is null) {
                return NotFound();
            }

            return Ok(discipline);
        }

    }
}

