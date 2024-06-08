using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Calendar
{
    [Key]
    public int Id { get; set; }
    public required DateTime Date { get; set; }

    public required int CarId { get; set; }
    public virtual Car Car { get; set; }
}
