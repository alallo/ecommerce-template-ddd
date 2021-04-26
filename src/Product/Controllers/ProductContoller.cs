using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Product.Controllers
{
    [ApiController]
    [Route("product")]
    [Produces("application/json")]
    public class ProductContoller : ControllerBase
    {

        private readonly ILogger<ProductContoller> _logger;

        public ProductContoller(ILogger<ProductContoller> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetProductList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> GetProductAsync()
        {
            return Ok(17);
        }
    }
}
