using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WineRack.Domain.Models;

namespace WineRack.Domain.Configurations
{
    public class WineryConfiguration : IEntityTypeConfiguration<Winery>
    {
        public void Configure(EntityTypeBuilder<Winery> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_Winery");

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
