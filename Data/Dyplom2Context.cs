using Microsoft.EntityFrameworkCore;
namespace boba_API.Models;

public partial class Dyplom2Context : DbContext
{
    public Dyplom2Context(DbContextOptions<Dyplom2Context> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }

    public DbSet<Car_Detail> CarDetails { get; set; }
    
    public DbSet<Role> Roles { get; set; }
    
    public DbSet<UserRole> UserRoles { get; set; }
    
    public DbSet<MechaniсWorkType> MechaniсWorkTypes { get; set; }
    
    public DbSet<Client> Clients { get; set; }

    public DbSet<Mechaniс> Mechaniks { get; set; }
    
    public DbSet<WorkType> WorkTypes  { get; set; }
 
}
