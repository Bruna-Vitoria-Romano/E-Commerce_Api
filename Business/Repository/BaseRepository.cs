using Business.Entyties;
using Business.Repository.Interfaces;
using Data.DataContext;

namespace Business.Repository
{
    public class BaseRepository<T> : IGenericInterface<T> where T : Base
    {
        private readonly Context _context;
        public Task<T> CreateAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync<T>(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
