using VehicleTrafficManagement.Enum;
namespace VehicleTrafficManagement.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public bool IsFirstAccess { get; set; } = true;
        public bool IsBlocked { get; set; } = false;
        public int? CompaniesId { get; set; }
        public Company Company { get; set; }
    }

}
