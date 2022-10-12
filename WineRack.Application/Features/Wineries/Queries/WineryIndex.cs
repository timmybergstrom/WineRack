using Microsoft.Extensions.Logging;
using WineRack.Application.Contracts;

namespace WineRack.Application.Wineries;

public class WineryIndexQuery : IRequest<List<Winery>>
{

}

internal class WineryIndexHandler : IRequestHandler<WineryIndexQuery, IEnumerable<Winery>>
{
    private readonly IWineryServices _services;
    //private readonly ILogger _logger;
    private IEnumerable<Winery> wineries;

    public WineryIndexHandler(IWineryServices services, //ILogger logger, 
        IEnumerable<Winery> wineries)
    {
        _services = services;
        //_logger = logger;
        this.wineries = wineries;
    }

    public async Task<IEnumerable<Winery>> Handle(WineryIndexQuery request, CancellationToken cancellationToken)
    {
        try
        {
            wineries = await _services.GetWineryList();
        }
        catch (Exception ex)
        {
            //_logger.LogError(null, ex.Message.ToString(), 1);
        }
        return wineries;
    }
}
