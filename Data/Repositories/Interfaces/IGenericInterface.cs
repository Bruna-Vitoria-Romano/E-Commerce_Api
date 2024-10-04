using Business.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IGenericInterface<T> where T : Base
    {
        Task<T> Create(T obj);

        Task<T> Update(T obj);

        Task<T> Remove(long Id);

        Task<T> Get(long Id);

        Task<List<T>> Get();
    }
}
