using Microsoft.AspNetCore.Mvc;
using WineRack.Application.Features.Wineries;

namespace WineRack.API.Controllers;

[ApiController]
[Route("winerack/wineries")]
public class WineryController : ControllerBase
{
    private readonly IMediator _mediator;

    public WineryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok(await _mediator.Send(new WineryIndexQuery(){}));
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetByID()
    {
        return Ok(await _mediator.Send(new GetWineryByIdQuery(){}));
    }
    
    [HttpPost("create")]
    public async Task<IActionResult> Create()
    {
        return Ok(await _mediator.Send(new CreateWineryQuery()));
    }
}