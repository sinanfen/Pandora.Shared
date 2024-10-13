namespace Pandora.Shared.DTOs.UserDTOs;

public class CorporateUserRegisterDto : UserRegisterDto
{
    public string CompanyName { get; set; }    // Required for corporate users
    public string TaxNumber { get; set; }      // Required for corporate users
}
