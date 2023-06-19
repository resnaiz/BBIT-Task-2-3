using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Models;

namespace test_code_rest_api.Database
{
    public class ApiDbContext : DbContext, IApiDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> context) : base(context)
        {
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Citizen> Citizens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .HasOne(a => a.Houses)
                .WithMany(h => h.Apartments)
                .HasForeignKey(a => a.HouseId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Citizen>()
                .HasOne(r => r.Apartment)
                .WithMany(a => a.Citizens)
                .HasForeignKey(r => r.ApartmentId)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
