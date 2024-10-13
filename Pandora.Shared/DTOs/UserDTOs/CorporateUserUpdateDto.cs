namespace Pandora.Shared.DTOs.UserDTOs;

public class CorporateUserUpdateDto : UserUpdateDto
{
    public string? CompanyName { get; set; }
    public string? TaxNumber { get; set; }
}