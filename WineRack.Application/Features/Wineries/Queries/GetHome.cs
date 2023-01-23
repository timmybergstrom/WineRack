using WineRack.Application.Contracts;

namespace WineRack.Application.Features.Wineries;

public class GetHome : IRequest<int>
{

}

public class GetHomeHandler : IRequestHandler<GetHome, int>
{
    private readonly IWineryServices _services;

    public GetHomeHandler(IWineryServices services)
    {
        _services = services;
    }

    public async Task<int> Handle(GetHome request, CancellationToken cancellationToken)
    {
        return 1;
    }
}
