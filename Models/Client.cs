using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class Client : User
{
    public virtual List<Car> Cars { get; set; }
}
