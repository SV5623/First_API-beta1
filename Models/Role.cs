using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Role
{
    [Key]
    public int Id { get; set; }

    public required string Role_Name { get; set; }

    public virtual List<UserRole> UserRoles { get; set; }
}
