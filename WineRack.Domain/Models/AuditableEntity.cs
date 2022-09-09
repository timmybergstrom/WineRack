namespace WineRack.Domain.Models;

public class AuditableEntity
{
    public DateTime CreatedDt { get; set; }
    public DateTime? ModifiedDt { get; set; }
    public int CreatedBy { get; set; }
    public int? ModifiedBy { get; set; }
}
