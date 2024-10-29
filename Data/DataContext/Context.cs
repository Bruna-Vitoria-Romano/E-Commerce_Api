using Business.Core.DTO;
using Business.Entyties;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }
    }
}
