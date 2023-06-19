using test_code_rest_api.Models;

namespace test_code_rest_api.Interfaces
{
    public interface IDbService
    {
        void Create<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        void Delete<T>(T entity) where T : Entity;
        T GetById<T>(int id) where T : Entity;
        IEnumerable<T> GetAll<T>() where T : Entity;
    }
}
