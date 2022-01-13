using MVP.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVP.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllActiveUsers();

        Task<bool> AddUser(User newUser);

        Task<bool> UpdateUser(int id);

        Task<bool> DeleteUser(int id);
    }
}