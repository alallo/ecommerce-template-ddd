using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.API.Settings;
using Product.Application.Queries;

namespace Product.Controllers
{
    [ApiController]
    [Route("product")]
    [Produces("application/json")]
    public class ProductContoller : ControllerBase
    {

        private readonly ILogger<ProductContoller> _logger;
        private readonly IMediator _mediator;

        public ProductContoller(ILogger<ProductContoller> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetProductList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> GetProductAsync(CancellationToken cancellationToken, int numberOfPages = Int32.MaxValue, int pageNumber = 0)
        {
            var response = await _mediator.Send(new GetProductListQuery { NumberOfPages = numberOfPages, PageNumber = pageNumber }, cancellationToken);
            return Ok(response);
        }
    }
}
