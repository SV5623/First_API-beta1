using System.ComponentModel.DataAnnotations;
namespace boba_API.Models;
public class Mechaniс : User
{
    [Key]
    public int Id { get; set; }
    public string Specialization { get; set; }
    public int Hours { get; set; }
    
    public List<MechaniсWorkType> MechanicWorkTypes { get; set; }
}