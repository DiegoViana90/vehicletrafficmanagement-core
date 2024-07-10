using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrafficManagement.Models;

namespace VehicleTrafficManagement.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> GetUserByEmail(string email);
        Task InsertUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}