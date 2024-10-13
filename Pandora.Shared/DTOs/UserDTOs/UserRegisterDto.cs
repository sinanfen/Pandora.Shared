using Pandora.Shared.Enums;
namespace Pandora.Shared.DTOs.UserDTOs;
public class UserRegisterDto
{
    // Common fields for all users
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }  // Optional but recommended for confirmation
    public string PhoneNumber { get; set; }
    public UserType UserType { get; set; } // Individual or Corporate
}
