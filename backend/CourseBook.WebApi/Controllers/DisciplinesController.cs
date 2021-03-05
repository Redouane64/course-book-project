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
    public class DisciplinesController : ControllerBase
    {

        [HttpGet("{id}", Name = nameof(GetDiscipline))]
        public async Task<IActionResult> GetDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPost(Name = nameof(CreateDiscipline))]
        public async Task<IActionResult> CreateDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpPut(Name = nameof(UpdateDiscipline))]
        public async Task<IActionResult> UpdateDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpGet(Name = nameof(GetAllDiscipline))]
        public async Task<IActionResult> GetAllDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }

        [HttpDelete(Name = nameof(DeleteDiscipline))]
        public async Task<IActionResult> DeleteDiscipline(CancellationToken cancellationToken = default)
        {
            return Ok();
        }
    }
}

