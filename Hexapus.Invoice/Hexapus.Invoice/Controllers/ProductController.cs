using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hexapus.Invoice.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hexapus.Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
