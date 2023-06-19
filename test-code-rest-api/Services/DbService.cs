using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Database;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Models;

namespace test_code_rest_api.Services
{
    public class DbService : IDbService
    {
        private readonly IApiDbContext _context;

        public DbService(IApiDbContext context)
        {
            _context = context;
        }

        public void Create<T>(T entity) where T : Entity
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : Entity
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : Entity
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T GetById<T>(int id) where T : Entity
        {
            return _context.Set<T>().Find(id)!;
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return _context.Set<T>().ToList();
        }
    }
}
