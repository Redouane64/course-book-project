namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Exceptions;
    using CourseBook.WebApi.Models;

    using MediatR;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Profiles.Commands;

    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = nameof(GetProfile))]
        [Authorize]
        public async Task<ActionResult> GetProfile(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost("login", Name =nameof(Login))]
        public async Task<IActionResult> Login([FromBody]LoginCredentials credentials, CancellationToken cancellationToken = default)
        {
            try
            {
                return Ok(await this._mediator.Send(new LoginRequest(credentials), cancellationToken));
            }
            catch (InvalidCredentialsException)
            {
                return BadRequest();
            }
        }

        [HttpPost("register", Name = nameof(Register))]
        public async Task<IActionResult> Register([FromBody] RegistrationForm form, CancellationToken cancellationToken = default)
        {
            return Ok(await this._mediator.Send(new RegisterAccountRequest(form), cancellationToken));
        }

        [HttpPatch("refresh-token", Name = nameof(RefreshToken))]
        [Authorize]
        public async Task<IActionResult> RefreshToken([FromBody] TokenModel tokens, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await this._mediator.Send(new RefreshTokenRequest(tokens)));
            }
            catch (InvalidRefreshTokenException)
            {
                return BadRequest();
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
        }
    }
}
