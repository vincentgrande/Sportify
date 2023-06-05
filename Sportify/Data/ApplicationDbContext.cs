using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sportify.Data.Models;

namespace Sportify.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Competition> Competitions { get; set; }
    public DbSet<Sport> Sports { get; set; }
    public DbSet<Constraint> Constraints { get; set; }
    public DbSet<Play> Plays { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
}