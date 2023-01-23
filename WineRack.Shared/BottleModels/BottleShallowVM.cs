namespace WineRack.Shared.Models.Bottles;

public class BottleShallowVM
{
    public int BottleId { get; set; }
    public string Vintage { get; set; } = string.Empty;
    public string Vineyard { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}