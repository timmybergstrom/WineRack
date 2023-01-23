namespace WineRack.Repository;

public class VerificationRepository : BaseRepository, IVerificationServices
{
    public VerificationRepository(WineRackContext wineRackDb) : base(wineRackDb)
    {
    }

    public async Task<bool> VerifyActiveUserById(int userId)
    {
        return await Task.Run(() => true);
    }
}
