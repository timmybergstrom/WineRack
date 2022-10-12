using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class BottleVarietalConfiguration : IEntityTypeConfiguration<BottleVarietal>
{
    public void Configure(EntityTypeBuilder<BottleVarietal> builder)
    {
        builder.HasKey(b => b.Id)
            .HasName("PK_BottleVarietal");

        builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();
    }
}
