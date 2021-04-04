namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Faculties.Commands;
    using CourseBook.WebApi.Faculties.Queries;
    using CourseBook.WebApi.Groups.Queries;
    using CourseBook.WebApi.Groups.ViewModels;
    using CourseBook.WebApi.Model;
    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("{directionId:Guid}/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class GroupsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetDirectionGroups))]
        [ProducesResponseType(typeof(IEnumerable<DirectionViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDirectionGroups([FromRoute] Guid directionId, CancellationToken cancellationToken = default)
        {
            var groups = await this._mediator.Send(new GetGroupsRequest(directionId), cancellationToken);
            return Ok(groups);
        }

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(GroupViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetGroup([FromRoute] Guid id)
        {
            var group = await this._mediator.Send(new GetGroupRequest(id));

            if (group is null)
            {
                return NotFound();
            }

            return Ok(group);
        }



        [HttpPost(Name = nameof(CreateGroup))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateGroup([FromRoute] Guid directionId, [FromBody]CreateGroup payload, CancellationToken cancellationToken)
        {
            var id = await this._mediator.Send(new CreateGroupRequest(payload.Name, directionId), cancellationToken);
            return CreatedAtAction(nameof(GetGroup), routeValues: new { id, directionId }, null);
        }

        [HttpPost(Name = nameof(EditGroup))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> EditGroup([FromBody] UpdateGroupRequest paylod, CancellationToken cancellationToken)
        {
            return Ok(await this._mediator.Send(new UpdateGroupRequest(paylod.GroupId, paylod.Name), cancellationToken));
        }

        [HttpDelete("{id:Guid}", Name = nameof(DeleteGroup))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteGroup([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            await this._mediator.Send(new DeleteGroupRequest(id), cancellationToken);
            return NoContent();
        }
    }

}
