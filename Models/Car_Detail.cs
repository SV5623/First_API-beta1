using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Car_Detail
{
    [Key]
    public int Id { get; set; }
    
    public required string Title { get; set; }
    public required decimal Price { get; set; }
    public string Code { get; set; }
    
    public int ClientId { get; set; }
    public Car Car { get; set; }
    
    public int StorageId { get; set; }
    public Storage Storage { get; set; }
}