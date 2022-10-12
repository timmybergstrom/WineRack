using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class VarietalConfiguration : IEntityTypeConfiguration<Varietal>
{
    public void Configure(EntityTypeBuilder<Varietal> builder)
    {
        builder.HasKey(v => v.Id)
            .HasName("PK_Varietals");

        builder.Property(v => v.Id)
            .ValueGeneratedOnAdd();

        builder.Property(v => v.GrapeVarietal)
            .IsRequired()
            .HasMaxLength(100);
    }
}
