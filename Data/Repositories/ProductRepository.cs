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
    public class ProductRepository : GenericRepository<ProductDTO>, IProductRepository
    {
        public ProductRepository(Context context, DbSet<ProductDTO> dbSet) : base(context, dbSet)
        {

        }
    }
}
