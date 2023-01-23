using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WineRack.API.Controllers;

[Route("winerack/bottles")]
[ApiController]
public class BottleController : ControllerBase
{
    private readonly IMediator _mediator;
    public BottleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateNew()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int bottleId)
    {
        return Ok();
    }
}
