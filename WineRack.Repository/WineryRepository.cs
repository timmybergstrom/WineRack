using Microsoft.EntityFrameworkCore;
using WineRack.Domain.Models;

namespace WineRack.Repository;

public class WineryRepository : AsyncRepository, IWineryServices
{
    public WineryRepository(WineRackContext wineRackDb) : base(wineRackDb)
    {
    }

    public async Task<Winery> GetWineryFull(int wineryId)
    {
        return await _wineRackDb.Wineries
            .Include(w => w.Country)
            .Include(w => w.Bottles)
            .Where(w => w.Id == wineryId)
            .FirstAsync();
    }

    public async Task<IEnumerable<Winery>> GetWineryList()
    {
        var wineries = await _wineRackDb.Wineries
            .Include(w => w.Country)
            .Include(w => w.Bottles)
            .Where(w => w.IsActive == true)
            .AsNoTracking()
            .ToListAsync();

        return wineries;
    }
}