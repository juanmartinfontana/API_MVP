using MVP.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVP.Core.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetAllActiveUsers();

        Task<bool> AddUser(User newUser);

        Task<bool> UpdateUser(int id);

        Task<bool> DeleteUser(int id);
    }
}