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
    public class GroupsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{directionId}", Name = nameof(GetGroup))]
        public async Task<IActionResult> GetGroup(string directionId, CancellationToken cancellationToken = default)
        {
            var groups = await this._mediator.Send(new GetGroupsRequest(directionId), cancellationToken);
            return Ok(groups);
        }

        [HttpPost(Name = nameof(CreateGroup))]
        public async Task<IActionResult> CreateGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateGroup))]
        public async Task<IActionResult> UpdateGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAllGroups))]
        public async Task<IActionResult> GetAllGroups(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteGroup))]
        public async Task<IActionResult> DeleteGroup(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }

}
