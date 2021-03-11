namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DisciplinesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{directionId}", Name = nameof(GetDiscipline))]
        public async Task<IActionResult> GetDiscipline(string directionId, CancellationToken cancellationToken = default)
        {
            var discipline = await this._mediator.Send(new GetDisciplinesRequest(directionId), cancellationToken);
            return Ok(discipline);
        }

        [HttpPost(Name = nameof(CreateDiscipline))]
        public async Task<IActionResult> CreateDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateDiscipline))]
        public async Task<IActionResult> UpdateDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAllDiscipline))]
        public async Task<IActionResult> GetAllDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteDiscipline))]
        public async Task<IActionResult> DeleteDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}

