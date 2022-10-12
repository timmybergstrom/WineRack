using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(c => c.Id)
            .HasName("PK_CountryId");

        builder.Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.CountryName)
            .IsRequired()
            .HasMaxLength(100);
    }
}
