using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WineRack.API.Controllers;

[Route("winerack/bottle")]
[ApiController]
public class BottleController : ControllerBase
{
    private readonly IMediator _mediator;
    public BottleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("collection")]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }

    [HttpGet("newBottle")]
    public async Task<IActionResult> CreateNew()
    {
        return Ok();
    }

    [HttpGet("bottle")]
    public async Task<IActionResult> GetById(int bottleId)
    {
        return Ok();
    }
}
