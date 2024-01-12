using Adverts.Application.Common.Models;
using Adverts.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Adverts.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertsController : Controller
    {

        private readonly ILogger<AdvertsController> _logger;
        private readonly IAdvertService _advertService;
        private readonly IAdvertVisitService _advertVisitService;

        public AdvertsController(IAdvertService advertService, IAdvertVisitService advertVisitService, ILogger<AdvertsController> logger)
        {
            _advertService = advertService;
            _advertVisitService = advertVisitService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromBody] int page, [FromBody] int limit)
        {
            var response = await _advertService.GetAllAsync(page,limit);

            if (!response.HasError)
                return Ok(response);

            if (!response.HasError && response.Result == null)
                return NotFound(response);

            return BadRequest(response);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var response = await _advertService.GetByIdAsync(id);

            if (!response.HasError)
                return Ok(response);

            if (!response.HasError && response.Result == null)
                return NotFound(response);

            return BadRequest(response);
        }

        [HttpPost]
        [Route("/visit")]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] int advertId)
        {
            var response = await _advertVisitService.CreateAdvertVisitAsync(advertId);

            if (!response.HasError)
                return Ok(response);

            return BadRequest(response);
        }
    }
}
