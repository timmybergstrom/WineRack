
using WineRack.Application.Contracts;

namespace WineRack.Application.Features;

public class VerifyUserWorker : IRequest<bool>
{
    public int UserId { get; set; }
}

internal class VerifyUserWorkerHandler : IRequestHandler<VerifyUserWorker, bool>
{
    private readonly IVerificationServices _services;

    public VerifyUserWorkerHandler(IVerificationServices services)
    {
        _services = services;
    }

    public async Task<bool> Handle(VerifyUserWorker request, CancellationToken cancellationToken)
    {
        return await _services.VerifyActiveUserById(request.UserId);
    }
}