using Business.Entyties;
using Data.Repository.Interfaces;
using Data.DataContext;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByName(string Name)
        {
            var user = await _context.Users.Where(x => x.Name.ToLower() == Name.ToLower()).AsNoTracking().ToListAsync();

            return user.FirstOrDefault();
        }
    }
}
