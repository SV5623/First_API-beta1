using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Car
{
    [Key]
    public int Id { get; set; }

    public required string Brand { get; set; }
    public string graduation_year { get; set; }
    public decimal Price { get; set; }
    public string warranty { get; set; }

    public int ClientId { get; set; }
    public virtual Client Client { get; set; }

    public virtual ICollection<Car_Detail> CarDetails { get; set; }
}
