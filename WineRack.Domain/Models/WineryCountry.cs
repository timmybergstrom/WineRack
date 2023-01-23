namespace WineRack.Domain.Models;

public class WineryCountry
{
    public WineryCountry()
    {
        Winery = new();
        Country = new();
    }

    public WineryCountry(Winery winery, Country country)
    {
        Winery = winery;
        Country = country;
    }

    public int Id { get; set; }
    public Winery Winery { get; set; }
    public Country Country {get;set;} 
}