using Microsoft.EntityFrameworkCore;
using MVP.Core.Entities;
using MVP.Core.Interfaces;
using MVP.Infraestructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MVPDBContext _context;

        public UserRepository(MVPDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllActiveUsers()
        {
            var users = await _context.User.Where(x => x.Active == true).ToListAsync();

            return users;
        }

        public async Task<bool> AddUser(User newUser)
        {
            _context.User.Add(newUser);
            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> UpdateUser(int idUser)
        {
            var currentUser = await _context.User.FirstOrDefaultAsync(x => x.IdUser == idUser);
            currentUser.Active = currentUser.Active == true ? false : true;

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteUser(int idUser)
        {
            var currentUser = await _context.User.FirstOrDefaultAsync(x => x.IdUser == idUser);
            _context.User.Remove(currentUser);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
