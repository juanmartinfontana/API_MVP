using MVP.Core.Entities;
using MVP.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVP.Core.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> AddUser(User newUser)
        {
            return await _userRepository.AddUser(newUser);
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }

        public async Task<IEnumerable<User>> GetAllActiveUsers()
        {
            return await _userRepository.GetAllActiveUsers();
        }

        public async Task<bool> UpdateUser(int id)
        {
            return await _userRepository.UpdateUser(id);
        }
    }
}
