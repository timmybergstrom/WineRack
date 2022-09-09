namespace WineRack.Domain.Models;

public class Winery : AuditableEntity
{
    public int Id { get; set; }
    public Country Country { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    
    //public List<Bottle> Bottles { get; set; } = new();

}
