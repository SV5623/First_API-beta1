
namespace boba_API.Models.Dto;

public class UserClientDTO
{
   
    public IList<string>? Roles { get; set; }
    public List<string>? Cars { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

}
