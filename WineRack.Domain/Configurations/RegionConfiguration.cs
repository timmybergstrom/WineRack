using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.HasKey(r => r.Id)
            .HasName("PK_RegionId");

        builder.Property(r => r.Id)
            .ValueGeneratedOnAdd();

        builder.Property(r => r.RegionName)
            .IsRequired();
    }
}
