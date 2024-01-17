using Adverts.Application.Common.Models;
using Adverts.Application.Common.Models.Request;
using Adverts.Application.Dtos;
using Adverts.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Adverts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertsController : Controller
    {

        private readonly IAdvertService _advertService;
        private readonly IAdvertVisitService _advertVisitService;

        public AdvertsController(IAdvertService advertService, IAdvertVisitService advertVisitService)
        {
            _advertService = advertService;
            _advertVisitService = advertVisitService;
        }

        [HttpGet]
        [Route("/all")]
        [ProducesResponseType(typeof(BaseResponse<PagedAdvertsDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse<PagedAdvertsDto>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(BaseResponse<PagedAdvertsDto>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromQuery] int page = 0, [FromQuery] int limit = 50)
        {
            var response = await _advertService.GetAllAsync(page, limit);

            if (!response.HasError && response.Result.Adverts.Count == 0)
                return NoContent();

            if (!response.HasError)
                return Ok(response);

            return BadRequest(response);
        }

        [HttpGet]
        [Route("/{advertId}")]
        [ProducesResponseType(typeof(BaseResponse<AdvertDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BaseResponse<AdvertDto>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(BaseResponse<AdvertDto>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] int advertId)
        {
            var response = await _advertService.GetByIdAsync(advertId);

            if (!response.HasError && response.Result == default(AdvertDto))
                return NoContent();

            if (!response.HasError)
                return Ok(response);

            return BadRequest(response);
        }

        [HttpPost]
        [Route("/visit")]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(BaseResponse<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] AdvertVisitCreateRequest request)
        {
            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            var response = await _advertVisitService.CreateAdvertVisitAsync(request.advertId, remoteIpAddress);

            if (!response.HasError)
                return Ok(response);

            return BadRequest(response);
        }
    }
}
