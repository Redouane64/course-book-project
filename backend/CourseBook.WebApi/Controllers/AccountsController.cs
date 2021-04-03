namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Exceptions;
    using CourseBook.WebApi.Identity.ViewModels;
    using Identity.Commands;
    using Identity.Models;
    using MediatR;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login", Name = nameof(Login))]
        [ProducesResponseType(typeof(TokenViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> Login([FromBody] LoginCredentials credentials, CancellationToken cancellationToken = default)
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
        [ProducesResponseType(typeof(TokenViewModel), StatusCodes.Status200OK)]
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

        [HttpPost("logout", Name = nameof(LogOut))]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> LogOut(CancellationToken cancellationToken = default)
        {
            await this._mediator.Send(new LogoutRequest(), cancellationToken);
            return NoContent();
        }
    }
}
