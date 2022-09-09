namespace WineRack.Domain.Models;

public class Region
{
    public int Id { get; set; }
    public Country Country { get; set; } = new();
    public string RegionName { get; set; } = string.Empty;
    //public List<Bottle> Bottles {get; set;} = new();
}

