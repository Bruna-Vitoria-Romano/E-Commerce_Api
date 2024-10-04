using Business.Entyties;
using Data.Repository.Interfaces;
using Data.DataContext;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetById(long id)
        {
            var product = await _context.Products.Where(y => y.Id == id).AsNoTracking().FirstOrDefaultAsync();

            return product;
        }
    }
}
