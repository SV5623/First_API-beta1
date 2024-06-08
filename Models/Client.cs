using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public virtual List<Car> Cars { get; set; }
}
