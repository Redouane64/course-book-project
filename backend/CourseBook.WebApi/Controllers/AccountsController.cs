using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost(Name =nameof(Login))]
        public async Task<IActionResult> Login(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost(Name = nameof(Register))]
        public async Task<IActionResult> Register(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}
