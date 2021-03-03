namespace CourseBook.WebApi.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using MediatR;

    using CourseBook.WebApi.Models;

    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly Mediator _mediator;

        public AccountsController(Mediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login", Name =nameof(Login))]
        public async Task<IActionResult> Login(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost("register", Name = nameof(Register))]
        public async Task<IActionResult> Register([FromBody] RegistrationForm form, CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}
