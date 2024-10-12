using Business.Entyties;
using Data.Repository.Interfaces;
using Data.DataContext;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Business.Core.DTO;
using Business.Core.AutoMapper;

namespace Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly Context _context;
        private readonly AutoMapperProfile _mapper;

        public UserRepository(Context context, AutoMapperProfile mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> GetByName(string Name)
        {
            var user = await _context.Users.Where(x => x.Name.ToLower() == Name.ToLower()).AsNoTracking().ToListAsync();

            return user.FirstOrDefault();
        }
    }
}
