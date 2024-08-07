using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrafficManagement.DTOs.Request;
using VehicleTrafficManagement.Models;

namespace VehicleTrafficManagement.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByEmailAndCompanyId(string email, int companyId);
        Task InsertUser(UserCreationRequest userCreationRequest);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
