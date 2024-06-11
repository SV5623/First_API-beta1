namespace boba_API.Models.Dto;

public class CarDetailsDTO
{
    public required string Title { get; set; }
    public required decimal Price { get; set; }
    public string Code { get; set; }

    public int ClientId { get; set; }
    public virtual Car Car { get; set; }

    public int StorageId { get; set; }
    public virtual Storage Storage { get; set; }
}