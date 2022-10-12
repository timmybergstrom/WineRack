using Microsoft.EntityFrameworkCore;

namespace WineRack.Repository;

public class VarietalRepository : AsyncRepository, IVarietalService
{
    public VarietalRepository(WineRackContext wineRackDb) : base(wineRackDb)
    {
    }

    public async Task<Dictionary<int, string>> VarietalDictionary()
    {
        return await _wineRackDb.Varietals
            .ToDictionaryAsync(v => v.Id, v => v.GrapeVarietal);
    }
}
