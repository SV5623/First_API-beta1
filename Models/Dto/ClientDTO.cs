
namespace boba_API.Models.Dto;

public class ClientDTO
{
    public IList<string> Roles { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
