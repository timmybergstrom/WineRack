using Microsoft.Extensions.Logging;
using WineRack.Application.Contracts;
using WineRack.Shared.Models.Winery;

namespace WineRack.Application.Features.Wineries;

public class WineryIndexQuery : IRequest<List<WineryFullVM>>
{

}

internal class WineryIndexHandler : IRequestHandler<WineryIndexQuery, List<WineryFullVM>>
{
    private readonly IWineryServices services;
    private readonly IMapper mapper;
    private readonly ILogger<WineryIndexHandler> logger;
    private List<WineryFullVM> wineriesVM = new();

    public WineryIndexHandler(IWineryServices services, IMapper mapper, ILogger<WineryIndexHandler> logger)
    {
        this.services = services;
        this.mapper = mapper;
        this.logger = logger;
    }

    public async Task<List<WineryFullVM>> Handle(WineryIndexQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var wineries = await services.GetWineryList();
            wineriesVM = mapper.Map<List<WineryFullVM>>(wineries);
            logger.LogInformation("Get winery started.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message.ToString());
        }
        return wineriesVM;
    }
}
