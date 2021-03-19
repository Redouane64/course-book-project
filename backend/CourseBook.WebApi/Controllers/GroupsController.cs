namespace CourseBook.WebApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public GroupsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetGroup([FromRoute] Guid id)
        {
            return Ok();
        }
    }

}
