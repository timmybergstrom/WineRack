using Microsoft.AspNetCore.Mvc;
using WineRack.Application.Wineries;

namespace WineRack.API.Controllers;

[ApiController]
[Route("winerack/winery")]
public class WineryController : ControllerBase
{
    private readonly IMediator _mediator;

    public WineryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("/index")]
    public async Task<IActionResult> Index()
    {
        return Ok(await _mediator.Send(new WineryIndexQuery(){}));
    }
    
}