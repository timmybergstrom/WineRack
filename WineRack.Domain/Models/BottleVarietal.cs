namespace WineRack.Domain.Models;

public class BottleVarietal : AuditableEntity
{
    public int Id { get; set; }
    public Bottle Bottle { get; set; } = new();
    public Varietal Varietal { get; set; } = new();
    public float Percentage { get; set; } 
}