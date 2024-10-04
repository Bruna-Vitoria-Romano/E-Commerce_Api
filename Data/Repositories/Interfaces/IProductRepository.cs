﻿
using Business.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IProductRepository : IGenericInterface<Product>
    {
        Task<Product> GetById(long id);
    }
}
