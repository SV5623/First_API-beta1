using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Password { get; set; }
    public required string Email { get; set; }

    public virtual List<UserRole> UserRoles { get; set; }
}
