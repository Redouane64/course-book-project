namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.ViewModels;
    using CourseBook.WebApi.Disciplines.Queries;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Commands;
    using CourseBook.WebApi.Faculties.Queries;
    using CourseBook.WebApi.Faculties.UpdateModels;
    using CourseBook.WebApi.Model;
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


        [HttpPost(Name = nameof(CreateDiscipline))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateDiscipline([FromBody]CreateDiscipline payload, CancellationToken cancellationToken)
        {
            var id = await this._mediator.Send(new CreateDisciplineRequest(payload), cancellationToken);
            return CreatedAtAction(nameof(GetDiscipline), routeValues: new { id }, null);
        }

        [HttpPut("{disciplineId:Guid}", Name = nameof(EditDiscipline))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> EditDiscipline([FromRoute]Guid disciplineId, [FromBody] UpdateDisciplineModel model, CancellationToken cancellationToken)
        {
            return Ok(await this._mediator.Send(new UpdateDisciplineRequest(disciplineId, model.Name), cancellationToken));
        }

        [HttpDelete("{id:Guid}", Name = nameof(DeleteDiscipline))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteDiscipline([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            await this._mediator.Send(new DeleteDisciplineRequest(id), cancellationToken);
            return NoContent();
        }
    }
}

