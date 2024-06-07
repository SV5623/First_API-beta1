using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class MechaniсWorkType
{
    [Key]
    public int Id { get; set; }
    public int MechanicId { get; set; }
    public Mechaniс Mechanic { get; set; }

    public int WorkTypeId { get; set; }
    public WorkType WorkType { get; set; }
}

