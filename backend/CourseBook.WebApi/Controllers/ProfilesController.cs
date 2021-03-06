
namespace CourseBook.WebApi.Controllers
{
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Models;

    using Profiles.Commands;
    using Profiles.Queries;

    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class ProfilesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetProfile))]
        [Authorize]
        public async Task<ActionResult> GetProfile(CancellationToken cancellationToken = default)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Ok(await this._mediator.Send(new GetProfileRequest(userId)));
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> UpdateProfile([FromBody] UpdateProfile profile, CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new UpdateProfileRequest(profile)));
        }

    }
}
