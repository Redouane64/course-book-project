
namespace CourseBook.WebApi.Controllers
{
    using System.Security.Claims;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.ViewModels;

    using MediatR;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Models;

    using Profiles.Commands;
    using Profiles.Queries;

    [Route("[controller]")]
    [ApiController]
    //[Produces("application/json")]
    //[Consumes("application/json", "multipart/form-data")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class ProfilesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetProfile))]
        [Authorize]
        [ProducesResponseType(typeof(ProfileViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetProfile(CancellationToken cancellationToken = default)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var profile = await this._mediator.Send(new GetProfileRequest(userId), cancellationToken);
            profile.Avatar = Url.Link(nameof(GetAvatar), null);

            return Ok(profile);
        }

        [HttpPost("update", Name = nameof(UpdateProfile))]
        [Authorize]
        [ProducesResponseType(typeof(ProfileViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateProfile([FromBody] UpdateProfile profile, CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new UpdateProfileRequest(profile), cancellationToken));
        }

        [HttpPost("upload-avatar", Name = nameof(UploadAvatar))]
        [Authorize]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(typeof(ProfileViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> UploadAvatar([FromForm]IFormFile file, CancellationToken cancellationToken)
        {
            await this._mediator.Send(new UploadAvatarRequest(file.OpenReadStream(), file.ContentType),
                cancellationToken);

            return CreatedAtAction(nameof(GetProfile), null);
        }

        [HttpGet("get-avatar", Name = nameof(GetAvatar))]
        [Authorize]
        //[Produces("image/jpeg", "image/png")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAvatar(CancellationToken cancellationToken)
        {
            var (contentType, stream) = await this._mediator.Send(new GetAvatarRequest());

            if (contentType is null)
            {
                return NotFound();
            }

            return File(stream, contentType);
        }
    }
}
