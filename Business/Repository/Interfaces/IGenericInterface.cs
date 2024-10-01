using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.Interfaces
{
    internal interface IGenericInterface<T> where T : class
    {
        Task<T> GetByIdAsync<T>(int id);
        Task<List<T>> GetAllAsync<T>();
        Task<T> CreateAsync<T>(T entity);
        Task<T> UpdateAsync<T>(int id, T entity);
        Task<T> DeleteAsync<T>(int id);
    }
}
