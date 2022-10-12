namespace WineRack.Domain.Models;

public class Winery : AuditableEntity
{
    public Winery()
    {   
        Bottles = new List<Bottle>();
    }

    public int Id { get; set; }
    public Country Country { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public List<Bottle> Bottles { get; set; } 

}
