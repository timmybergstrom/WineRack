using Microsoft.AspNetCore.Mvc;
using WineRack.Application.Features.Wineries;

namespace WineRack.API.Controllers
{
    [ApiController]
    [Route("winerack/")]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _mediator.Send(new GetHome(){}));
        }
    }
}
