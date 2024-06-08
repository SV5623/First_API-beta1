using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Storage
{
    [Key]
    public int Id { get; set;}
    public int number_of_seats { get; set; }
    
    public List<Car_Detail> CarDetails { get; set; }
}