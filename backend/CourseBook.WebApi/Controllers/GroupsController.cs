namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Groups.Queries;
    using CourseBook.WebApi.Groups.ViewModels;

    using MediatR;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class GroupsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            _mediator = mediator;
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
    }

}
