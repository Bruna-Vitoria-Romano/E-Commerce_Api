using Business.Entyties;
using Data.Repository.Interfaces;
using Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BaseRepository<T> : IGenericInterface<T> where T : Base
    {
        private readonly Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }

        public async Task<T> Create(T obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public async Task<T> Get(long Id)
        {
            var obj = await _context.Set<T>().AsNoTracking().Where(x => x.Id == Id).ToListAsync();

            return obj.FirstOrDefault();
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> Remove(long Id)
        {
            var obj = await Get(Id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }

            return obj;
        }

        public async Task<T> Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }
    }
}
