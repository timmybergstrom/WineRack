using WineRack.Application.Contracts;
using WineRack.Shared.Models.Winery;

namespace WineRack.Application.Features.Wineries;

public class GetWineryByIdQuery : IRequest<WineryFullVM>
{
    public int WineryId { get; set; }
    public int UserId { get; set; }
}

internal class GetWineryByIdHandler : IRequestHandler<GetWineryByIdQuery, WineryFullVM>
{
    private readonly IWineryServices _services;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    private WineryFullVM _winery = new();

    public GetWineryByIdHandler(IWineryServices services, IMediator mediator, IMapper mapper)
    {
        _services = services;
        _mediator = mediator;
        _mapper = mapper;
    }
    public async Task<WineryFullVM> Handle(GetWineryByIdQuery request, CancellationToken cancellationToken)
    {
        bool activeId = await _mediator.Send(new VerifyUserWorker(){ UserId = request.UserId});
        if(activeId)
        {
            try
            {
                await GetWineryWithBottlesById(request.WineryId);
            }
            catch (Exception ex)
            {
                _winery.Success = false;
                _winery.Message = $"The method failed: {ex.Message.ToString()}";
            }
        }
        else
        {
            _winery.Success = false;
            _winery.Message = "You are not a registered user.";
        }
        return _winery;
    }

    public async Task<Unit> GetWineryWithBottlesById(int wineryId)
    {
        var winery = await _services.GetWineryFull(wineryId);
        if(winery is not null)
        {
            _winery = _mapper.Map<WineryFullVM>(winery);
        }
        else
        {
            _winery.Success = false;
            _winery.Message = ("The Winery requested was not found");
        }
        return Unit.Value;
    }
}
