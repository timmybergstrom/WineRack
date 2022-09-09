namespace WineRack.Domain.Models;

public class TastingNote : AuditableEntity
{
    public int Id { get; set; }
    public Bottle Bottle { get; set; } = new();
    public string Notes { get; set; } = string.Empty;

}
