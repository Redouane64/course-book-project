namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Admin.Models;
    using CourseBook.WebApi.Admin.Queries;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetUsers))]
        [ProducesResponseType(typeof(IEnumerable<UserViewModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUsers(CancellationToken cancellationToken = default)
        {
            var users = await this._mediator.Send(new GetUsersRequest(), cancellationToken);
            return Ok(users);
        }

        [HttpDelete("{userId:Guid}", Name = nameof(DeleteUser))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteUser([FromRoute] string userId, CancellationToken cancellationToken)
        {
            var currentUser = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (currentUser is not null && currentUser == userId) {
                return BadRequest();
            }

            await this._mediator.Send(new DeleteUserRequest(userId), cancellationToken);

            return NoContent();
        }

        [HttpPut(Name =nameof(SetRoles))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> SetRoles([FromBody]SetRoleModel model, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
