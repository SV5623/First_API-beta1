using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Car_Detail
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
}