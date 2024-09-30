using Business.Entyties;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infra.DataContext
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
