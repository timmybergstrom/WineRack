using WineRack.Shared.Models.Bottles;

namespace WineRack.Shared.Models.Winery;

public class WineryFullVM : BaseResponse
{
    public int WineryId { get; set; }
    public string WineryName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public List<BottleShallowVM> Bottles { get; set; } = new();
}