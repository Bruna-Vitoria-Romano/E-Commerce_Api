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
using Business.Core.DTO;
using AutoMapper;

namespace Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context, IMapper mapper) : base(context)
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
