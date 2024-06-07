using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Client : User
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Car_Detail> CarDetails { get; set; }
}