using Microsoft.Extensions.Logging;
using WineRack.Application.Contracts;

namespace WineRack.Application.Features.Wineries;

public class CreateWineryQuery : IRequest<int>
{}

public class CreateWineryHandler : IRequestHandler<CreateWineryQuery, int>
{
    private readonly IWineryServices _services;
    private readonly ILogger<CreateWineryHandler> _logger;

    public CreateWineryHandler(IWineryServices serviecs, ILogger<CreateWineryHandler> logger)
    {
        _services = serviecs;
        _logger = logger;
    }
    
    public Task<int> Handle(CreateWineryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
} 