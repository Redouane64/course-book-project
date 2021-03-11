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

    [Route("[controller]")]
    [ApiController]
    public class FacultiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FacultiesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}", Name = nameof(GetFaculty))]
        public async Task<IActionResult> GetFaculty(CancellationToken cancellationToken = default)
        {
            var faculties = await this._mediator.Send(new GetFacultiesRequest(), cancellationToken);
            return Ok(faculties);
        }

        [HttpPost(Name = nameof(CreateFaculty))]
        public async Task<IActionResult> CreateFaculty(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateFaculty))]
        public async Task<IActionResult> UpdateFaculty(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAllFaculties))]
        public async Task<IActionResult> GetAllFaculties(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteFaculty))]
        public async Task<IActionResult> DeleteFaculty(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}
