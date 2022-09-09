namespace WineRack.Domain.Models;

public class BottleNote : AuditableEntity
{
    public int Id  { get; set; }
    public string Notes { get; set; } = string.Empty;
}
