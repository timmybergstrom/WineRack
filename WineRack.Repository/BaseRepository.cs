using WineRack.Domain;

namespace WineRack.Repository;

public class BaseRepository : IBaseServices
{
    protected readonly WineRackContext _wineRackDb;

    public BaseRepository(WineRackContext wineRackDb)
    {
        _wineRackDb = wineRackDb;
    }

    public Task<bool> IsDbAvailable()
    {
        throw new NotImplementedException();
    }
}
