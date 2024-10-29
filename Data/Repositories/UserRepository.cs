using Business.Entyties;
using Data.Repository.Interfaces;
using Data.DataContext;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Business.Core.DTO;
using Business.Core.AutoMapper;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<UserDTO>, IUserRepository
    {
        public UserRepository(Context context, DbSet<UserDTO> dbSet) : base(context, dbSet)
        {

        }
    }
}
