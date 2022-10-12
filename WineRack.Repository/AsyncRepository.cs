namespace WineRack.Repository;

public class AsyncRepository : BaseRepository, IAsyncServices
{
    public AsyncRepository(WineRackContext wineRackDb) : base(wineRackDb)
    {
    }
}