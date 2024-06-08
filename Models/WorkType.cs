using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class WorkType
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }

    public virtual List<MechaniсWorkType> MechanicWorkTypes { get; set; }
}
