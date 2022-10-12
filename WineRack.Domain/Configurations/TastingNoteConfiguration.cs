using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class TastingNatoConfiguration : IEntityTypeConfiguration<TastingNote>
{
    public void Configure(EntityTypeBuilder<TastingNote> builder)
    {
        builder.HasKey(t => t.Id)
            .HasName("PK_TastingNoteId");

        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Notes)
            .IsRequired()
            .HasMaxLength(4000);
    }
}
