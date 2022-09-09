namespace WineRack.Domain.Models;

    public class Bottle : AuditableEntity
    {
        public int Id { get; set; }
        //public Winery Winery { get; set; } = new();
        //public Region Region { get; set; } = new();
        public string Vintage { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int NumberOfBottles { get; set; }
        public float PurchasePrice { get; set; }
        public BottleNote BottleNote { get; set; } = new();
        public List<TastingNote> TastingNoteList { get; set; } = new();
        public List<BottleVarietal> BottleVarietalList {get; set; }  = new();
    }

