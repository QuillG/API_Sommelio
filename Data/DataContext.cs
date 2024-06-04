using Microsoft.EntityFrameworkCore;
using Sommelio.Entities;

namespace Sommelio.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProfessionalType> ProfessionalTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyProduct> CompanyProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<WineType> WineTypes { get; set; }
        public DbSet<ColorsBtn> ColorsBtn { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Cepage> Cepages { get; set; }
        public DbSet<Delicacies> Delicacies { get; set; }
        public DbSet<DelicaciesWine> DelicaciesWines { get; set; }
        public DbSet<ScannedUser> ScannedUsers { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<FavEvents> FavEvents { get; set; }
        public DbSet<FidelityRank> FidelityRanks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserType)
                .WithMany()
                .HasForeignKey(u => u.UserTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.FidelityGrade)
                .WithMany()
                .HasForeignKey(u => u.FidelityGradeId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Beer)
                .WithMany()
                .HasForeignKey(p => p.BeerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Wine)
                .WithMany()
                .HasForeignKey(p => p.WineId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Wine>()
                .HasOne(w => w.WineType)
                .WithMany()
                .HasForeignKey(w => w.WineTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Wine>()
                .HasOne(w => w.TypeApellation)
                .WithMany()
                .HasForeignKey(w => w.TypeAppellationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Wine>()
                .HasOne(w => w.Region)
                .WithMany()
                .HasForeignKey(w => w.RegionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Wine>()
                .HasOne(w => w.Cepage)
                .WithMany()
                .HasForeignKey(w => w.CepageId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Region>()
                .HasOne(r => r.Country)
                .WithMany()
                .HasForeignKey(r => r.CountryId);

            modelBuilder.Entity<DelicaciesWine>()
                .HasOne(dw => dw.Wine)
                .WithMany()
                .HasForeignKey(dw => dw.WineId);

            modelBuilder.Entity<DelicaciesWine>()
                .HasOne(dw => dw.Delicacies)
                .WithMany()
                .HasForeignKey(dw => dw.DelicaciesId);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Address)
                .WithMany()
                .HasForeignKey(c => c.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.Userid)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ScannedUser>()
                .HasOne(su => su.User)
                .WithMany()
                .HasForeignKey(su => su.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ScannedUser>()
                .HasOne(su => su.Company)
                .WithMany()
                .HasForeignKey(su => su.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Events>()
                .HasOne(e => e.Company)
                .WithMany()
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Events>()
                .HasOne(e => e.Address)
                .WithMany()
                .HasForeignKey(e => e.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FavEvents>()
                .HasOne(fe => fe.Events)
                .WithMany()
                .HasForeignKey(fe => fe.EventId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FavEvents>()
                .HasOne(fe => fe.User)
                .WithMany()
                .HasForeignKey(fe => fe.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CompanyProduct>()
                .HasOne(cp => cp.Company)
                .WithMany()
                .HasForeignKey(cp => cp.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CompanyProduct>()
                .HasOne(cp => cp.Product)
                .WithMany()
                .HasForeignKey(cp => cp.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Address)
                .WithMany()
                .HasForeignKey(u => u.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RefreshToken>()
                .HasOne(rt => rt.User)
                .WithMany()
                .HasForeignKey(rt => rt.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<WineType>()
                .HasOne(wt => wt.ColorsBtn)
                .WithMany()
                .HasForeignKey(wt => wt.ColorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delicacies>()
                .HasOne(d => d.ColorsBtn)
                .WithMany()
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delicacies>()
                .HasOne(d => d.parent)
                .WithMany()
                .HasForeignKey(d => d.parentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CompanyProduct>()
                .HasKey(cp => new { cp.CompanyId, cp.ProductId });

            modelBuilder.Entity<DelicaciesWine>()
                .HasKey(dw => new { dw.WineId, dw.DelicaciesId });

            modelBuilder.Entity<ScannedUser>()
                .HasKey(su => new { su.CompanyId, su.UserId });
        }


    }
}
