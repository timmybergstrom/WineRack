using WineRack.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WineRack.Domain.Configurations;

public class BottleConfiguration : IEntityTypeConfiguration<Bottle>
{
    public void Configure(EntityTypeBuilder<Bottle> builder)
    {
        builder.HasKey(b => b.Id)
            .HasName("PK_Bottle");

        builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();    

        builder.Property(b => b.Name)
            .IsRequired();

        builder.Property(b => b.Vintage)
            .HasMaxLength(4);         
    }
}