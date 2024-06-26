﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace boba_API.Models;

public class Dyplom2Context : IdentityDbContext<User>
{
    public Dyplom2Context(DbContextOptions<Dyplom2Context> options) : base(options)
    {
    }

    // public DbSet<User> Users { get; set; }

    public DbSet<Car_Detail> CarDetails { get; set; }

    public DbSet<MechaniсWorkType> MechaniсWorkTypes { get; set; }

    public DbSet<Car> Clients { get; set; }

    public DbSet<Mechaniс> Mechaniks { get; set; }

    public DbSet<WorkType> WorkTypes { get; set; }

}
