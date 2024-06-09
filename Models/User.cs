using Microsoft.AspNetCore.Identity;

namespace boba_API.Models;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
