using Microsoft.EntityFrameworkCore;
using WineRack.Domain.Models;

namespace WineRack.Domain;

public class WineRackContext : DbContext
{
    private int i = 1;
    public WineRackContext(DbContextOptions<WineRackContext> options) : base(options)
    {
        
    }

        public DbSet<BottleNote> BottleNotes { get; set; } 
        public DbSet<Bottle> Bottles { get; set; }
        public DbSet<BottleVarietal> BottleVarietals { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<TastingNote> TastingNotes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Varietal> Varietals { get; set; }
        public DbSet<Winery> Wineries { get;set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch ( entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDt = DateTime.Now;
                    break;

                case EntityState.Modified:
                    entry.Entity.ModifiedDt = DateTime.Now;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof (WineRackContext).Assembly);

        //modelBuilder.Entity<Bottle>()
          //  .HasOne(w => w.Winery)
           // .WithMany()
           // .OnDelete(DeleteBehavior.Cascade);

        //modelBuilder.Entity<Winery>()
        //    .HasMany(w => w.Bottles)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        #region Countries
        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "USA"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Spain"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "France"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Italy"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Germany"
        });
        
        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "South Africa"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Australia"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Chile"
        });

        modelBuilder.Entity<Country>().HasData(new Country
        {
            Id = i++,
            CountryName = "Brazil"
        });
        #endregion

        #region Varietals
        i = 1;
        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Zinfandel"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Cabernet Sauvignon"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Merlot"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Pinot Noir"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Pinot Grigio"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Sauvignon Blanc"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Chardonnay"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Malbec"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Carignan(e)"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Petit Verdot"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Alicante"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Baco Noir"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Barbera"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Cabernet Franc"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Cinsault"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "de Chaunac"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Dolcetto"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Freisa"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Gamay"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Gamay Beaujolais"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Grenache"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Grignolino"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Kadarka"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Lambrusco"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Marechal Foch"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Mourvedre"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Nebbiolo"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Petite Sirah"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Pinot Meunier"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Pinotage"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Primitivo"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Ruby Cabarnet"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Sangiovese"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Syrah"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Tempranillo"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Touriga Nacional"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Xynomavro"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Aglianco"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Semillon"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Moscato"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Gewurztraminer"        
        });

        modelBuilder.Entity<Varietal>().HasData(new Varietal
        {
            Id = i++,
            GrapeVarietal = "Riesling"        
        });
        #endregion
    }
}


