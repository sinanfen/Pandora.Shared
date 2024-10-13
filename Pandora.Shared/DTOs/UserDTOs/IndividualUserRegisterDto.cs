namespace Pandora.Shared.DTOs.UserDTOs;

public class IndividualUserRegisterDto : UserRegisterDto
{
    public string FirstName { get; set; }      // Required for individual users
    public string LastName { get; set; }       // Required for individual users
}