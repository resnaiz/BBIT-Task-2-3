using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using test_code_rest_api.Models;

namespace test_code_rest_api.Database
{
    public interface IApiDbContext
    {
        DbSet<House> Houses { get; set; }
        DbSet<Apartment> Apartments { get; set; }
        DbSet<Citizen> Citizens { get; set; }
        public int SaveChanges();
        public DbSet<T> Set<T>() where T : class;
        public EntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
