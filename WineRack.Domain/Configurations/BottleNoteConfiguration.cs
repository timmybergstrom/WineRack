using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class BottleNoteConfiguration : IEntityTypeConfiguration<BottleNote>
{
    public void Configure(EntityTypeBuilder<BottleNote> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName("PK_BottleNote");

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}
