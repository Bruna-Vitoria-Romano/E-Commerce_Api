using AutoMapper;
using Business.Core.DTO;
using Business.Entyties;
using Data.DataContext;
using Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(Context context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public async Task AddAsync(T entity)
        {
            var addEntity = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(object id)
        {
            if (id == null) { throw new Exception("Id cannot be null"); }

            var deleteEntity = await _dbSet.FindAsync(id);
            _dbSet.Remove(deleteEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            if (id == null) { throw new Exception("Id cannot be null"); }

            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) { throw new Exception("Entity not found"); }

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
