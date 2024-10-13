using Pandora.Shared.Enums;

namespace Pandora.Shared.DTOs.UserDTOs;

public class UserUpdateDto : BaseDto<Guid>
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public UserType UserType { get; set; }
    public DateTime? LastLoginDate { get; set; } // Last login timestamp
}
